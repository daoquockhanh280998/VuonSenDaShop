﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDaShop.Application.Dtos
{
    public class PagingRequestBase
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
