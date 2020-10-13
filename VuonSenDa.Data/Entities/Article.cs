using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public int ViewTime { get; set; }
        public int ViewCount { get; set; }
        public int Position { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CreateBy { get; set; }

        public int ArticleCategoryId { get; set; }
        public ArticleCategory  ArticleCategory { get; set; }
        public List<ArticleTranslation> ArticleTranslations { get; set; }
        public List<ArticleImage> ArticleImages { get; set; }

    }
}
