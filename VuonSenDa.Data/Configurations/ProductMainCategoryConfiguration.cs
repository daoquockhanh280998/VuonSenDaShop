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
    class ProductMainCategoryConfiguration : IEntityTypeConfiguration<ProductMainCategory>
    {
        public void Configure(EntityTypeBuilder<ProductMainCategory> builder)
        {
            builder.ToTable("ProductMainCategories");
            builder.HasKey(x => x.ProductMainCategoryId);
            builder.Property(x => x.ProductMainCategoryId).UseIdentityColumn();
            builder.Property(x => x.ProductMainCategoryName).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired();
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Dercription).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Position);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);

            
        }
    }
}
