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
    class ArticleMainCategoryConfiguration : IEntityTypeConfiguration<ArticleMainCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleMainCategory> builder)
        {
            builder.ToTable("ArticleMainCategories");
            builder.HasKey(x => x.ArticleMainCategoryId);
            builder.Property(x => x.ArticleMainCategoryId).UseIdentityColumn();
            builder.Property(x => x.ArticleMainCategoryName).HasMaxLength(255).IsUnicode(false).IsRequired();
            builder.Property(x => x.Dercription).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Avatar).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Thumb).HasMaxLength(4000).IsRequired(false);
            builder.Property(x => x.Position).HasDefaultValue(1);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateBy).HasMaxLength(255).IsRequired(false);
        }
    }
}
