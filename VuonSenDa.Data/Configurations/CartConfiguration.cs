using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDaShop.Data.Configurations
{
    class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.CartId);
            builder.Property(x => x.CartId).UseIdentityColumn(1, 1);

            builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Carts).HasForeignKey(x => x.UserId);
           
        }
    }
}
