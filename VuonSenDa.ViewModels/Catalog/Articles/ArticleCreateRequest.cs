using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Catalog.Articles
{
    public class ArticleCreateRequest
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Dercription { get; set; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string CreateBy { get; set; }
        public string LanguageId { set; get; }
        public int ArticleCategoryId { get; set; }

        //IFormFile là kiểu file nhị phân
        public IFormFile ThumbnailImage { get; set; }
    }
}
