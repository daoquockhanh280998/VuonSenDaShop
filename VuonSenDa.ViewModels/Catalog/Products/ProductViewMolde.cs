using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Catalog.Products
{
    public class ProductViewMolde
    {
        public int ProductId { get; set; }
        public string ProductTranslationName { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Details { set; get; }
        public string Dercription { get; set; }
        public int Stock { get; set; }
        public int ViewTime { get; set; }
        public int ViewCount { get; set; }
        public DateTime? DateCreate { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public int ProductCategoryId { get; set; }
        public string LanguageId { set; get; }
    }
}
