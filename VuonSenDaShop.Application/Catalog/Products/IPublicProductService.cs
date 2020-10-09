using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.ViewModels.Catalog.Products;
using VuonSenDa.ViewModels.Common;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewMolde>> GetALLByMainCategoryID(GetPublicProductPagingRequest request);
        Task<PagedResult<ProductViewMolde>> GetALLByCategoryID(GetPublicProductPagingRequest request);

        Task<List<ProductViewMolde>> GetAll();
    }
}
