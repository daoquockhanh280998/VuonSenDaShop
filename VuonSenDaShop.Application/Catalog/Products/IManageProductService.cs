using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.ViewModels.Catalog.Products;
using VuonSenDa.ViewModels.Common;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> AddImages(ImageCreateRequest request);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(ImageCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);
        Task<int> Delete(int productID);

        Task<PagedResult<ProductViewMolde>> GetALLPaging(GetManageProductPagingRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
