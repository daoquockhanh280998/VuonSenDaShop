using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.ViewModels.Catalog.Articles;
using VuonSenDa.ViewModels.Common;

namespace VuonSenDaShop.Application.Catalog.Articles
{
    public interface IPublicArticleService
    {
        Task<PagedResult<AticleViewMolde>> GetALLByCategoryID(string languageId, GetPublicArticlePagingRequest request);

        Task<List<AticleViewMolde>> GetAll(string languageId);
    }
}
