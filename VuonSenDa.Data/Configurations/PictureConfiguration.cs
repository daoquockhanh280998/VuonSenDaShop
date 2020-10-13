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
    class PictureConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.ToTable("Pictures");
            builder.HasKey(x => x.PictureId);
            builder.Property(x => x.PictureId).UseIdentityColumn(1, 1);
            builder.Property(x => x.PictureName).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired();
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Position);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.DateCreate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);
        }
    }
}
