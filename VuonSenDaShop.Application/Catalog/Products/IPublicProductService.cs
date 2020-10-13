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
        Task<PagedResult<ProductViewMolde>> GetALLByMainCategoryID(string languageId, GetPublicProductPagingRequest request);
        Task<PagedResult<ProductViewMolde>> GetALLByCategoryID(string languageId, GetPublicProductPagingRequest request);

        Task<List<ProductViewMolde>> GetAll(string languageId);
    }
}
