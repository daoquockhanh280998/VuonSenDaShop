using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class AdminAccountCategory
    {
        public int AdminAccountCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public string Thumb { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }

        public List<AdminAccount> AdminAccounts { get; set; }

    }
}
