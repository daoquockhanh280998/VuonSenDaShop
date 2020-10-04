using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public int PhoneNumber { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }

    }
}
