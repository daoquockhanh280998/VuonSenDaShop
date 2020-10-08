using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Application.Dtos;

namespace VuonSenDaShop.Application.Catalog.Products.Dtos_DatatranferObject_.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? mainCategoryID { get; set; }
        public int? CategoryID { get; set; }
    }
}
