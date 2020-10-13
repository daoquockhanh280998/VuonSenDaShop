using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDa.ViewModels.Common;

namespace VuonSenDa.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public string languageId { get; set; }
        public int? mainCategoryID { get; set; }
        public int? CategoryID { get; set; }
    }
}
