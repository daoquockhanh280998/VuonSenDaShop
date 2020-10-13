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
    class AdminAccountCategoryConfiguration : IEntityTypeConfiguration<AdminAccountCategory>
    {
        public void Configure(EntityTypeBuilder<AdminAccountCategory> builder)
        {
            builder.ToTable("AdminAccountCategorys");
            builder.HasKey(x => x.AdminAccountCategoryId);
            builder.Property(x => x.AdminAccountCategoryId).UseIdentityColumn(1, 1);
            builder.Property(x => x.Title).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);


        }
    }
}
