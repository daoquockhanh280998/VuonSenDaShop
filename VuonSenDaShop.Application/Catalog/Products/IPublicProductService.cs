using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Public;
using VuonSenDaShop.Application.Dtos;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
       Task<PagedResult<ProductViewMolde>> GetALLByMainCategoryID(GetProductPagingRequest request);
        Task<PagedResult<ProductViewMolde>> GetALLByCategoryID(GetProductPagingRequest request);
    }
}
