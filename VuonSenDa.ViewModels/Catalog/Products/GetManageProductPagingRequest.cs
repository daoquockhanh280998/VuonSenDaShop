using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDa.ViewModels.Common;

namespace VuonSenDa.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> MainCategoryIds { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
