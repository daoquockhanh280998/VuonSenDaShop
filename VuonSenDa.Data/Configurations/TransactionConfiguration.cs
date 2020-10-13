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
    class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(x => x.TransactionId);
            builder.Property(x => x.TransactionId).UseIdentityColumn(1, 1);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);

        }
    }
}
