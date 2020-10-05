using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Data.Configurations.Translation
{
    class ProductMainCategoryTranslationConfiguration : IEntityTypeConfiguration<ProductMainCategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductMainCategoryTranslation> builder)
        {
            builder.ToTable("ProductMainCategoryTranslations");

            builder.HasKey(x => x.ProductMainCategoryTranslationId);

            builder.Property(x => x.ProductMainCategoryTranslationId).UseIdentityColumn();


            builder.Property(x => x.ProductMainCategoryTranslationName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ProductMainCategoryTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.ProductMainCategory).WithMany(x => x.ProductMainCategoryTranslations).HasForeignKey(x => x.ProductMainCategoryId);
        }
    }
}
