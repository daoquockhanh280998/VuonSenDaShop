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
    class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.ArticleId);
            builder.Property(x => x.ArticleId).UseIdentityColumn();
            builder.Property(x => x.ArticleName).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Dercription).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.ViewTime).HasMaxLength(50);
            builder.Property(x => x.ViewCount).HasMaxLength(50);
            builder.Property(x => x.Position).HasDefaultValue(1);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);

            builder.HasOne(x => x.ArticleCategory).WithMany(x => x.Articles)
                .HasForeignKey(x => x.ArticleCategoryId);
        }
    }
}
