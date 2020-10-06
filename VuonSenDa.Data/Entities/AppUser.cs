using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using ShopOnlineGamingPC.Data.Entities;

namespace VuonSenDaShop.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
