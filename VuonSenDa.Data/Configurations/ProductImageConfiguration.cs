using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Configurations
{
    class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1,1);
            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Caption).HasMaxLength(200);
            

            builder.HasOne(t => t.Product).WithMany(p => p.ProductImages)
                .HasForeignKey(cp => cp.ProductId);
        }
    }
}
