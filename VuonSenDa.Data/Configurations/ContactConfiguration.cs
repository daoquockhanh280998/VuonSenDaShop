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
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.ContactId);
            builder.Property(x => x.ContactId).UseIdentityColumn(1, 1);
            builder.Property(x => x.ContactName).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(50);
            builder.Property(x => x.Content).HasMaxLength(4000).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.DateCreate).HasDefaultValue(DateTime.Now);
        }
    }
}
