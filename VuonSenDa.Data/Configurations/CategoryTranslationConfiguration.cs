using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDaShop.Data.Configurations
{
    class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsUnicode(false).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SeoDescription).IsRequired().HasMaxLength(500); ;
            builder.Property(x => x.SeoTitle).IsRequired().HasMaxLength(500); ;
            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(500); ;
            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);
        }
    }
}
