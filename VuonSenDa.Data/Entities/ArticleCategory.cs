using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class ArticleCategory
    {
        public int ArticleCategoryId { get; set; }
        public int Position { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CreateBy { get; set; }

        public List<Article> Articles { get; set; }
        public List<ArticleCategoryTranslation> ArticleCategoryTranslations { get; set; }
    }
}
