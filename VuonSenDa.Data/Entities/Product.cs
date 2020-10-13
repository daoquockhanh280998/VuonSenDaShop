using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewTime { get; set; }
        public int ViewCount { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CreateBy { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<OrderDetail>  OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
