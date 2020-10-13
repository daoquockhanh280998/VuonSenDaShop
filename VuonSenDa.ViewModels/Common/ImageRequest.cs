using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.ViewModels.Common
{
    public class ImageRequest
    {
        public int? Id { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }

        //IFormFile là kiểu file nhị phân
        public IFormFile ImageFile { get; set; }
    }
}