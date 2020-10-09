using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.Utilities.Exceptions;
using VuonSenDa.ViewModels.Catalog.Products;
using VuonSenDa.ViewModels.Common;
using VuonSenDaShop.Application.Common;
using VuonSenDaShop.Data.EF;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {

        private readonly VuonSenDaShopDbContext _db;
        private readonly IStorageService _storageService;
        public ManageProductService(VuonSenDaShopDbContext db, IStorageService storageService)
        {
            _db = db;
            _storageService = storageService;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Avatar = request.Avatar,
                Thumb = request.Thumb,
                ViewTime = 0,
                ViewCount = 0,
                DateCreate = DateTime.Now,
                CreateBy = request.CreateBy,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        //do đang thêm kiểu cha con nên tự động add productID vào
                        ProductTranslationName = request.Name,
                        Dercription=request.Dercription,
                        Details=request.Details,
                        SeoDescription=request.SeoDescription,
                        SeoTitle=request.SeoTitle,
                        SeoAlias=request.SeoAlias,
                        LanguageId=request.LanguageId
                    }
                }
            };

            //save image
            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption="Thumnail image",
                        DateCreate = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }

            _db.Products.Add(product);
            return await _db.SaveChangesAsync();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim();
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _db.Products.FindAsync(productId);
            product.ViewCount += 1;
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
        }


        public async Task<int> Delete(int productID)
        {
            var product = await _db.Products.FindAsync(productID);
            if (product == null)
            {
                throw new VuonSenDaException($"Cannot Find a product with id: {productID}");
            }
            var images = _db.ProductImages.Where(x => x.ProductId == productID);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }
            _db.Products.Remove(product);
            return await _db.SaveChangesAsync();
        }


        public async Task<PagedResult<ProductViewMolde>> GetALLPaging(GetManageProductPagingRequest request)
        {
            //1.select join
            var query = from p in _db.Products
                        join pc in _db.ProductCategories on p.ProductCategoryId equals pc.ProductCategoryId
                        join pmc in _db.ProductMainCategories on pc.ProductMainCategoryId equals pmc.ProductMainCategoryId
                        join pt in _db.ProductTranslations on p.ProductId equals pt.ProductId
                        where pt.ProductTranslationName.Contains(request.keyword)
                        select new { p, pt, pmc, pc };
            //2.filter
            //filter equals keyword
            if (!string.IsNullOrEmpty(request.keyword))
                query = query.Where(x => x.pt.ProductTranslationName.Contains(request.keyword));
            //filter equals MainCategoryIds
            if (request.MainCategoryIds.Count > 0)
            {
                query = query.Where(x => request.MainCategoryIds.Contains(x.pmc.ProductMainCategoryId));
            }
            //filter equals CategoryIds
            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(x => request.CategoryIds.Contains(x.pc.ProductCategoryId));
            }

            //3.paging
            // lấy totalRow search là bao nhiêu
            int totalRow = await query.CountAsync();

            var data = query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(x => new ProductViewMolde()
                {
                    ProductId = x.p.ProductId,
                    ProductTranslationName = x.pt.ProductTranslationName,
                    Avatar = x.p.Avatar,
                    Thumb = x.p.Thumb,
                    DateCreate = x.p.DateCreate,
                    Dercription = x.pt.Dercription,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    Price = x.p.Price,
                    OriginalPrice = x.p.OriginalPrice,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                    ViewTime = x.p.ViewTime
                }).ToListAsync();

            //4.Select and  Projection
            var pageResult = new PagedResult<ProductViewMolde>()
            {
                TotalRecord = totalRow,
                Items = await data
            };
            return pageResult;
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _db.Products.FindAsync(request.Id);
            var productTranslations = await _db.ProductTranslations
                                               .FirstOrDefaultAsync(x => x.ProductId == request.Id
                                               && x.LanguageId == request.LanguageId);

            if (product == null || productTranslations == null)
                throw new VuonSenDaException($"Cannot Find a product with id: {request.Id}");

            productTranslations.ProductTranslationName = request.ProductTranslationName;
            productTranslations.Dercription = request.Dercription;
            productTranslations.Details = request.Details;
            productTranslations.SeoAlias = request.SeoAlias;
            productTranslations.SeoDescription = request.SeoDescription;
            productTranslations.SeoTitle = request.SeoTitle;
            productTranslations.ProductTranslationName = request.ProductTranslationName;
            //save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _db.ProductImages
                                              .FirstOrDefaultAsync(x => x.IsDefault == true
                                              && x.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _db.ProductImages.Update(thumbnailImage);
                }
            }

            return await _db.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _db.Products.FindAsync(productId);
            if (product == null)
                throw new VuonSenDaException($"Cannot Find a product with id: {productId}");
            product.Price = newPrice;
            return await _db.SaveChangesAsync() > 0;// save thành công sẽ là true và nguoc lai
        }

        public async Task<bool> UpdateStock(int productId, int addQuantity)
        {
            var product = await _db.Products.FindAsync(productId);
            if (product == null)
                throw new VuonSenDaException($"Cannot Find a product with id: {productId}");
            product.Stock += addQuantity;
            return await _db.SaveChangesAsync() > 0;// save thành công sẽ là true và nguoc lai
        }

        public async Task<int> AddImages(ImageCreateRequest request)
        {
            var image = new ProductImage()
            {
                ProductId = request.ProductId,
                Caption = request.Caption,
                DateCreate = DateTime.Now,
                FileSize = request.FileSize,
                ImagePath = request.ImagePath,
                IsDefault = request.IsDefault,
                SortOrder = request.SortOrder
            };
            _db.ProductImages.Add(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> RemoveImages(int imageId)
        {
            var images = _db.ProductImages.Where(x => x.Id == imageId).FirstOrDefault();

            _db.ProductImages.Remove(images);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> UpdateImages(ImageCreateRequest request)
        {
            var image = await _db.ProductImages.FindAsync(request.Id);
            if (image == null)
                throw new VuonSenDaException($"Cannot Find a image with id: {request.Id}");

            image.Caption = request.Caption;
            image.FileSize = request.FileSize;
            image.ImagePath = request.ImagePath;
            image.IsDefault = request.IsDefault;
            image.SortOrder = request.SortOrder;

            return await _db.SaveChangesAsync();
        }

        public Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
