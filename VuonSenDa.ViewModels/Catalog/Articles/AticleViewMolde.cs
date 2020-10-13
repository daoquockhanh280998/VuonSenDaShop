using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Catalog.Articles
{
    public class AticleViewMolde
    {
        public int ArticleId { get; set; }
        public string ArticleTranslationName { get; set; }
        public string Details { set; get; }
        public string Dercription { get; set; }
        public int ViewTime { get; set; }
        public int ViewCount { get; set; }
        public DateTime? DateCreate { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public int ArticleCategoryId { get; set; }
        public string LanguageId { set; get; }
    }
}
