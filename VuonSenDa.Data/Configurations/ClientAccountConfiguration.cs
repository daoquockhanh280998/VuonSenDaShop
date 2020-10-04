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
    class ClientAccountConfiguration : IEntityTypeConfiguration<ClientAccount>
    {
        public void Configure(EntityTypeBuilder<ClientAccount> builder)
        {
            builder.ToTable("ClientAccounts");
            builder.HasKey(x => x.ClientAccountId);
            builder.Property(x => x.ClientAccountId).UseIdentityColumn();
            builder.Property(x => x.Password).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Gender).HasDefaultValue(Gender.Male);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);
        }
    }
}
