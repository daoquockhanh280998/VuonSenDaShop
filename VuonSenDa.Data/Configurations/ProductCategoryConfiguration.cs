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
    class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(x => x.ProductCategoryId);
            builder.Property(x => x.ProductCategoryId).UseIdentityColumn();
            builder.Property(x => x.ProductCategoryName).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired();
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Dercription).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Position);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);

            builder.HasOne(x => x.ProductMainCategory).WithMany(x => x.ProductCategories)
                .HasForeignKey(x => x.ProductMainCategoryId);
        }
    }
}
