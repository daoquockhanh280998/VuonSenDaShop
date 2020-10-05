using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class AdminAccount
    {
        public int AdminAccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Thumb { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CreateBy { get; set; }

        public int AdminAccountCategoryId { get; set; }
        public AdminAccountCategory AdminAccountCategory { get; set; }

    }
}
