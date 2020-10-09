
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Catalog.Products
{
    public class ImageCreateRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreate { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        //IFormFile là kiểu file nhị phân
        public IFormFile formFiles { get; set; }
    }
}
