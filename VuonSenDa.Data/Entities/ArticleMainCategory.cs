using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class ArticleMainCategory
    {
        public int ArticleMainCategoryId { get; set; }
        public string ArticleMainCategoryName { get; set; }
        public string Dercription { get; set; }
        public string Avatar { get; set; }
        public string Thumb { get; set; }
        public int Position { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CreateBy { get; set; }


        public List<ArticleCategory> ArticleCategories { get; set; }

        
    }
}
