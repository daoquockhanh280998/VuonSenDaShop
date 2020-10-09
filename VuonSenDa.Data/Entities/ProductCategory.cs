using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class ProductCategory 
    {
        public int ProductCategoryId { get; set; }
        public string Avatar { get; set; }
        public string Thumb { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CreateBy { get; set; }
        public int ProductMainCategoryId { get; set; }
        public ProductMainCategory ProductMainCategory { get; set; }

        public List<Product> Products { get; set; }

        public List<ProductCategoryTranslation> ProductCategoryTranslations { get; set; }
    }
}
