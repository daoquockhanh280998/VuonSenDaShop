using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDaShop.Data.Entities
{
   public class ArticleImage
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreate { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public Article Article { get; set; }

    }
}
