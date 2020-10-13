using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string FilePath { get; set; }
        public int IsDefault { get; set; }
        public long FileSize { get; set; }
        public int productID { get; set; }
        public int sortOrder { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
