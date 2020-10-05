using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class ProductCategoryTranslation
    {
        public int ProductCategoryTranslationId { get; set; }
        public string ProductCategoryTranslationName { get; set; }
        public string Dercription { get; set; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public string LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
