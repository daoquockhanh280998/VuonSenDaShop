using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class ProductMainCategoryTranslation
    {
        public int ProductMainCategoryTranslationId { get; set; }
        public string ProductMainCategoryTranslationName { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }

        public int ProductMainCategoryId { get; set; }
        public ProductMainCategory ProductMainCategory { get; set; }

        public string LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
