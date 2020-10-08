using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Application.Dtos;

namespace VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Manage
{
   public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> MainCategoryIds { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
