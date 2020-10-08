using System;
using System.Collections.Generic;
using System.Text; 

namespace VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string ProductTranslationName { get; set; }
        public string Dercription { get; set; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }

    }
}
