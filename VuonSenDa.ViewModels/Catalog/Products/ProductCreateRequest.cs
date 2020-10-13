
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Details { set; get; }
        public string Dercription { get; set; }
        public int Stock { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string CreateBy { get; set; }
        public string LanguageId { get; set; }
        public int ProductCategoryId { get; set; }

        //IFormFile là kiểu file nhị phân
        public IFormFile ThumbnailImage { get; set; }
    }
}
