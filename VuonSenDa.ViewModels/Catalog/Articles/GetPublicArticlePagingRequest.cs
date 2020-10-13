using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDa.ViewModels.Common;

namespace VuonSenDa.ViewModels.Catalog.Articles
{
    public class GetPublicArticlePagingRequest : PagingRequestBase
    {
        public string languageId { get; set; }
        public int? CategoryID { get; set; }
    }
}
