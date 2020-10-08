using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Public;
using VuonSenDaShop.Application.Dtos;
using VuonSenDaShop.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly VuonSenDaShopDbContext _db;
        public PublicProductService(VuonSenDaShopDbContext db)
        {
            _db = db;
        }
        public async Task<PagedResult<ProductViewMolde>> GetALLByCategoryID(GetProductPagingRequest request)
        {
            //1.select join
            var query = from p in _db.Products
                        join pc in _db.ProductCategories on p.ProductCategoryId equals pc.ProductCategoryId
                        join pmc in _db.ProductMainCategories on pc.ProductMainCategoryId equals pmc.ProductMainCategoryId
                        join pt in _db.ProductTranslations on p.ProductId equals pt.ProductId
                        select new { p, pt, pmc, pc };
            //2.filter
            //filter equals CategoryIds
            if (request.CategoryID.HasValue && request.CategoryID.Value > 0)
            {
                query = query.Where(p => p.pc.ProductCategoryId == request.CategoryID);
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

        public async Task<PagedResult<ProductViewMolde>> GetALLByMainCategoryID(GetProductPagingRequest request)
        {
            //1.select join
            var query = from p in _db.Products
                        join pc in _db.ProductCategories on p.ProductCategoryId equals pc.ProductCategoryId
                        join pmc in _db.ProductMainCategories on pc.ProductMainCategoryId equals pmc.ProductMainCategoryId
                        join pt in _db.ProductTranslations on p.ProductId equals pt.ProductId
                        select new { p, pt, pmc, pc };
            //2.filter
            //filter equals MainCategoryIds
            if (request.mainCategoryID.HasValue && request.mainCategoryID.Value > 0)
            {
                query = query.Where(p => p.pc.ProductMainCategoryId == request.mainCategoryID);
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
    }
}
