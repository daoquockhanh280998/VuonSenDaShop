using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.ViewModels.Catalog.Articles;
using VuonSenDa.ViewModels.Common;

namespace VuonSenDaShop.Application.Catalog.Articles
{
    public interface IManageArticleService
    {
        Task<int> Create(ArticleCreateRequest request);
        Task<int> Update(ArticleUpdateRequest request);
        Task<int> Delete(int articleId);

        Task<int> AddImages(ImageRequest request,int articleId);
        Task<int> UpdateImages(ImageRequest request, int articleId);

        Task<int> RemoveImages(int imageId);

    }
}
