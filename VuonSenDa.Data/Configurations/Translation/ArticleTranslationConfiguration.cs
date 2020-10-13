using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Data.Configurations.Translation
{
    class ArticleTranslationConfiguration : IEntityTypeConfiguration<ArticleTranslation>
    {
        public void Configure(EntityTypeBuilder<ArticleTranslation> builder)
        {
            builder.ToTable("ArticleTranslations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(1,1);


            builder.Property(x => x.ArticleTranslationName).IsRequired().HasMaxLength(400);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(400);

            builder.Property(x => x.Dercription).HasMaxLength(1000);

            builder.Property(x => x.Details).HasMaxLength(4000);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ArticleTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Article).WithMany(x => x.ArticleTranslations).HasForeignKey(x => x.ArticleId);
        }
    }
}
