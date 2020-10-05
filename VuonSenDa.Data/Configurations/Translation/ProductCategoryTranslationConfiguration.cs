using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;

namespace VuonSenDaShop.Data.Configurations.Translation
{
    class ProductCategoryTranslationConfiguration : IEntityTypeConfiguration<ProductCategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryTranslation> builder)
        {
            builder.ToTable("ProductCategoryTranslations");

            builder.HasKey(x => x.ProductCategoryTranslationId);

            builder.Property(x => x.ProductCategoryTranslationId).UseIdentityColumn();


            builder.Property(x => x.ProductCategoryTranslationName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ProductCategoryTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.ProductCategory).WithMany(x => x.ProductCategoryTranslations).HasForeignKey(x => x.ProductCategoryId);
        }
    }
}
