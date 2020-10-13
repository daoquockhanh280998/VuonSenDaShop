using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VuonSenDa.ViewModels.Catalog.Articles;
using VuonSenDa.ViewModels.Common;
using VuonSenDaShop.Application.Common;
using VuonSenDaShop.Data.EF;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Application.Catalog.Articles
{
    public class ManageArticleService : IManageArticleService
    {
        private readonly VuonSenDaShopDbContext _db;
        private readonly IStorageService _storageService;
        public ManageArticleService(VuonSenDaShopDbContext db, IStorageService storageService)
        {
            _db = db;
            _storageService = storageService;
        }
        public async Task<int> Create(ArticleCreateRequest request)
        {
            var article = new Article()
            {
                CreateBy = request.CreateBy,
                ViewTime = 0,
                ViewCount = 0,
                ArticleCategoryId = request.ArticleCategoryId,
                ArticleTranslations = new List<ArticleTranslation>()
                {
                    new ArticleTranslation()
                    {
                        ArticleTranslationName = request.Name,
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
                article.ArticleImages = new List<ArticleImage>()
                {
                    new ArticleImage()
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

            _db.Articles.Add(article);
            await _db.SaveChangesAsync();
            return article.ArticleId;

        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }

        public Task<int> Update(ArticleUpdateRequest request)
        {
            throw new NotImplementedException();
        }
        public Task<int> Delete(int articleId)
        {
            throw new NotImplementedException();
        }


        public Task<int> AddImages(ImageRequest request, int articleId)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveImages(int imageId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateImages(ImageRequest request, int articleId)
        {
            throw new NotImplementedException();
        }
    }
}
