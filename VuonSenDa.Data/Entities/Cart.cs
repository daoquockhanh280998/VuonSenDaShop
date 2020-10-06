using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;

namespace ShopOnlineGamingPC.Data.Entities
{
    public class Cart
    {
        public int CartId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
