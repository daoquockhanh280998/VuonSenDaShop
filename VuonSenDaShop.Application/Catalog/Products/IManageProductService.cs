using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_;
using VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Manage;
using VuonSenDaShop.Application.Dtos;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);
        Task<int> Delete(int productID);


        Task<PagedResult<ProductViewMolde>> GetALLPaging(GetProductPagingRequest request);
    }
}
