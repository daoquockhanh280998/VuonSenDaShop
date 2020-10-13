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
    class AdminAccountConfiguration : IEntityTypeConfiguration<AdminAccount>
    {
        public void Configure(EntityTypeBuilder<AdminAccount> builder)
        {
            builder.ToTable("AdminAccounts");
            builder.HasKey(x => x.AdminAccountId);
            builder.Property(x => x.AdminAccountId).UseIdentityColumn(1, 1);
            builder.Property(x => x.Username).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Gender).HasDefaultValue(Gender.Male);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);

            builder.HasOne(x => x.AdminAccountCategory).WithMany(x => x.AdminAccounts)
                  .HasForeignKey(x => x.AdminAccountCategoryId);


        }
    }
}
