using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.Utilities.Exceptions;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Manage;
using VuonSenDaShop.Application.Dtos;
using VuonSenDaShop.Data.EF;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {

        private readonly VuonSenDaShopDbContext _db;
        public ManageProductService(VuonSenDaShopDbContext db)
        {
            _db = db;
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
            _db.Products.Add(product);
            return await _db.SaveChangesAsync();
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
            _db.Products.Remove(product);

            return await _db.SaveChangesAsync();
        }

     
        public async Task<PagedResult<ProductViewMolde>> GetALLPaging(GetProductPagingRequest request)
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

            return await _db.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _db.Products.FindAsync(productId);
            if (product == null )
                throw new VuonSenDaException($"Cannot Find a product with id: {productId}");
            product.Price = newPrice;
            return await _db.SaveChangesAsync() > 0 ;// save thành công sẽ là true và nguoc lai
        }

        public async Task<bool> UpdateStock(int productId, int addQuantity)
        {
            var product = await _db.Products.FindAsync(productId);
            if (product == null)
                throw new VuonSenDaException($"Cannot Find a product with id: {productId}");
            product.Stock += addQuantity;
            return await _db.SaveChangesAsync() > 0;// save thành công sẽ là true và nguoc lai
        }
    }
}
