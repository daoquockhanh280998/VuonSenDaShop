using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;

namespace ShopOnlineGamingPC.Data.Entities
{
    public class Language
    {
        public string LanguageId { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<ProductCategoryTranslation> ProductCategoryTranslations { get; set; }
        public List<ProductMainCategoryTranslation> ProductMainCategoryTranslations { get; set; }
        public List<ArticleTranslation> ArticleTranslations { get; set; }
        public List<ArticleCategoryTranslation> ArticleCategoryTranslations { get; set; }
    }
}
