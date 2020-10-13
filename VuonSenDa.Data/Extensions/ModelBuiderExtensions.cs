using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Entities;
using VuonSenDaShop.Data.Enums;

namespace VuonSenDaShop.Data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region Entity<AppConfig>
            modelBuilder.Entity<AppConfig>().HasData(
                  new AppConfig() { Key = "HomeTitle", Value = "This is home page of Vuon Sen Da" },
                  new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of Vuon Sen Da" },
                  new AppConfig() { Key = "HomeDescription", Value = "This is description of Vuon Sen Da" }
                   );
            #endregion

            #region Entity<Language>
            modelBuilder.Entity<Language>().HasData(
                new Language() { LanguageId = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { LanguageId = "en-US", Name = "English", IsDefault = false }
                );
            #endregion

            #region Entity<ProductMainCategory>
            modelBuilder.Entity<ProductMainCategory>().HasData(
                   new ProductMainCategory()
                   {
                       ProductMainCategoryId = 1,
                       Avatar = "hinh",
                       Thumb = null,
                       Status = Status.Active,
                       CreateBy = "Admin"
                   },
                   new ProductMainCategory()
                   {
                       ProductMainCategoryId = 2,
                       Avatar = "hinh",
                       Thumb = null,
                       Status = Status.Active,
                       CreateBy = "Admin"
                   }

                   );
            #endregion

            #region Entity<ProductMainCategoryTranslation>
            modelBuilder.Entity<ProductMainCategoryTranslation>().HasData(
                   new ProductMainCategoryTranslation()
                   {
                       ProductMainCategoryTranslationId = 1,
                       ProductMainCategoryTranslationName = "Sen đá bịch/chậu nhựa",
                       LanguageId = "vi-VN",
                       SeoAlias = "sen-da-bich-chau-nhua",
                       SeoDescription = "Sen đá bịch/chậu nhựa",
                       SeoTitle = "Sen đá bịch/chậu nhựa",
                       ProductMainCategoryId = 1,
                   },
                   new ProductMainCategoryTranslation()
                   {
                       ProductMainCategoryTranslationId = 2,
                       ProductMainCategoryTranslationName = "Stone Lotus Plastic Pots",
                       LanguageId = "en-US",
                       SeoAlias = "Stone-Lotus-Plastic-Pots",
                       SeoDescription = "Stone-Lotus-Plastic-Pots",
                       SeoTitle = "Stone-Lotus-Plastic-Pots",
                       ProductMainCategoryId = 1,
                   },
                   new ProductMainCategoryTranslation()
                   {
                       ProductMainCategoryTranslationId = 3,
                       ProductMainCategoryTranslationName = "Xương rồng",
                       LanguageId = "vi-VN",
                       SeoAlias = "Xuong-Rong",
                       SeoDescription = "Xương rồng",
                       SeoTitle = "Xương rồng",
                       ProductMainCategoryId = 2,
                   },
                   new ProductMainCategoryTranslation()
                   {
                       ProductMainCategoryTranslationId = 4,
                       ProductMainCategoryTranslationName = "Cactus",
                       LanguageId = "en-US",
                       SeoAlias = "Cactus",
                       SeoDescription = "Cactus",
                       SeoTitle = "Cactus",
                       ProductMainCategoryId = 2,
                   }

                   );
            #endregion


            #region Entity<ProductCategory>
            modelBuilder.Entity<ProductCategory>().HasData(
                   new ProductCategory()
                   {
                       ProductCategoryId = 1,
                       Avatar = "hinh",
                       Thumb = null,
                       Status = Status.Active,
                       CreateBy = "Admin",
                       ProductMainCategoryId = 1
                   },
                    new ProductCategory()
                    {
                        ProductCategoryId = 2,
                        Avatar = "hinh",
                        Thumb = null,
                        Status = Status.Active,
                        CreateBy = "Admin",
                        ProductMainCategoryId = 1
                    },
                     new ProductCategory()
                     {
                         ProductCategoryId = 3,
                         Avatar = "hinh",
                         Thumb = null,
                         Status = Status.Active,
                         CreateBy = "Admin",
                         ProductMainCategoryId = 2
                     }
                   );
            #endregion

            #region Entity<ProductCategoryTranslation>
            modelBuilder.Entity<ProductCategoryTranslation>().HasData(
                   new ProductCategoryTranslation()
                   {
                       ProductCategoryTranslationId = 1,
                       ProductCategoryTranslationName = "Sen đá cỡ nhỏ",
                       LanguageId = "vi-VN",
                       SeoAlias = "sen-da-co-nho",
                       SeoDescription = "Sen đá cỡ nhỏ",
                       SeoTitle = "Sen đá cỡ nhỏ",
                       ProductCategoryId = 1,
                   },
                   new ProductCategoryTranslation()
                   {
                       ProductCategoryTranslationId = 2,
                       ProductCategoryTranslationName = "Small Stone Lotus",
                       LanguageId = "en-US",
                       SeoAlias = "Small-Stone-Lotus",
                       SeoDescription = "Small Stone Lotus",
                       SeoTitle = "Small Stone Lotus",
                       ProductCategoryId = 1,
                   },
                   new ProductCategoryTranslation()
                   {
                       ProductCategoryTranslationId = 3,
                       ProductCategoryTranslationName = "Sen đá cỡ Lớn",
                       LanguageId = "vi-VN",
                       SeoAlias = "Sen-Da-Co-Lon",
                       SeoDescription = "Sen đá cỡ Lớn",
                       SeoTitle = "Sen đá cỡ Lớn",
                       ProductCategoryId = 2,
                   },
                   new ProductCategoryTranslation()
                   {
                       ProductCategoryTranslationId = 4,
                       ProductCategoryTranslationName = "Big Stone Lotus",
                       LanguageId = "en-US",
                       SeoAlias = "Big-Stone-Lotus",
                       SeoDescription = "Big Stone Lotus",
                       SeoTitle = "Big Stone Lotus",
                       ProductCategoryId = 2,
                   },
                   new ProductCategoryTranslation()
                   {
                       ProductCategoryTranslationId = 5,
                       ProductCategoryTranslationName = "Xương Rồng",
                       LanguageId = "vi-VN",
                       SeoAlias = "Xuong-Rong",
                       SeoDescription = "Sen đá cỡ Lớn",
                       SeoTitle = "Sen đá cỡ Lớn",
                       ProductCategoryId = 3,
                   },
                   new ProductCategoryTranslation()
                   {
                       ProductCategoryTranslationId = 6,
                       ProductCategoryTranslationName = "Cactus",
                       LanguageId = "en-US",
                       SeoAlias = "Cactus",
                       SeoDescription = "Cactus",
                       SeoTitle = "Cactus",
                       ProductCategoryId = 3,
                   }
                   );
            #endregion

            #region Entity<Product>
            modelBuilder.Entity<Product>().HasData(
                   new Product()
                   {
                       ProductId = 1,
                       Price = 20000,
                       OriginalPrice = 25000,
                       Stock = 0,
                       ViewTime = 0,
                       ViewCount = 0,
                       Status = Status.Active,
                       CreateBy = "Admin",
                       ProductCategoryId = 1
                   },
                    new Product()
                    {
                        ProductId = 2,
                        Price = 40000,
                        OriginalPrice = 45000,
                        Stock = 0,
                        ViewTime = 0,
                        ViewCount = 0,
                        Status = Status.Active,
                        CreateBy = "Admin",
                        ProductCategoryId = 2
                    },
                      new Product()
                      {
                          ProductId = 3,
                          Price = 50000,
                          OriginalPrice = 55000,
                          Stock = 0,
                          ViewTime = 0,
                          ViewCount = 0,
                          Status = Status.Active,
                          CreateBy = "Admin",
                          ProductCategoryId = 3
                      }
                   );
            #endregion

            #region Entity<ProductTranslation>
            modelBuilder.Entity<ProductTranslation>().HasData(
                   new ProductTranslation()
                   {
                       ProductTranslationId = 1,
                       ProductTranslationName = "Sen Dù Hồng 3-5cm (Chậu Nhựa)",
                       LanguageId = "vi-VN",
                       Details = "Sen Dù Hồng 3-5cm (Chậu Nhựa)",
                       Dercription = "Sen Dù Hồng 3-5cm (Chậu Nhựa)",
                       SeoAlias = "sen-du-hong-3-5cm",
                       SeoDescription = "Sen Dù Hồng 3-5cm (Chậu Nhựa)",
                       SeoTitle = "Sen Dù Hồng 3-5cm (Chậu Nhựa)",
                       ProductId = 1,
                   },
                   new ProductTranslation()
                   {
                       ProductTranslationId = 2,
                       ProductTranslationName = "Stone Lotus Du Hong 3-5cm (Plastic pots)",
                       LanguageId = "en-US",
                       Details = "Pink  Stone Lotus 3-5cm (Plastic Pots)",
                       Dercription = "Pink  Stone Lotus 3-5cm (Plastic Pots)",
                       SeoAlias = "Stone-Lotus-Du-Hong-3-5cm-(Plastic-pots)",
                       SeoDescription = "Stone Lotus Du Hong 3-5cm (Plastic pots)",
                       SeoTitle = "Stone Lotus Du Hong 3-5cm (Plastic pots)",
                       ProductId = 1,
                   },
                    new ProductTranslation()
                    {
                        ProductTranslationId = 3,
                        ProductTranslationName = "Sen Dù Hồng 5-10cm ",
                        LanguageId = "vi-VN",
                        Details = "Sen Dù Hồng 5-10cm ",
                        Dercription = "Sen Dù Hồng 5-10cm ",
                        SeoAlias = "sen-du-hong-3-5cm",
                        SeoDescription = "Sen Dù Hồng 3-5cm ",
                        SeoTitle = "Sen Dù Hồng 3-5cm ",
                        ProductId = 2,
                    },
                   new ProductTranslation()
                   {
                       ProductTranslationId = 4,
                       ProductTranslationName = "Stone Lotus Du Hong 5-10cm ",
                       LanguageId = "en-US",
                       Details = "Pink  Stone Lotus 5-10cm (Plastic Pots)",
                       Dercription = "Pink  Stone Lotus 5-10cm (Plastic Pots)",
                       SeoAlias = "Stone-Lotus-Du-Hong-5-10cm",
                       SeoDescription = "Stone Lotus Du Hong 5-10cm",
                       SeoTitle = "Stone Lotus Du Hong 5-10cm",
                       ProductId = 2,
                   },
                      new ProductTranslation()
                      {
                          ProductTranslationId = 5,
                          ProductTranslationName = "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ",
                          LanguageId = "vi-VN",
                          Details = "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ",
                          Dercription = "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ",
                          SeoAlias = "xuong-rong-than-long",
                          SeoDescription = "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ",
                          SeoTitle = "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ",
                          ProductId = 3,
                      },
                   new ProductTranslation()
                   {
                       ProductTranslationId = 6,
                       ProductTranslationName = "Dragon Spirit Cactus 7-9cm (Plastic Pots)",
                       LanguageId = "en-US",
                       Details = "Dragon Spirit Cactus 7-9cm (Plastic Pots)",
                       Dercription = "Dragon Spirit Cactus 7-9cm (Plastic Pots) ",
                       SeoAlias = "Dragon-Spirit-Cactus-7-9cm-Plastic Pots",
                       SeoDescription = "Dragon Spirit Cactus 7-9cm (Plastic Pots)",
                       SeoTitle = "Dragon Spirit Cactus 7-9cm (Plastic Pots)",
                       ProductId = 3,
                   }
                   );
            #endregion

            #region ADMIN_ID
            // any guid
            var adminID = new Guid("08F06AC0-5706-465E-AD7B-5BFA88117B00");
            var roleID = new Guid("7ED48C67-F62F-43DF-AD4B-1FF27E5DAF21");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "daoquockhanh280998@gmail.com",
                NormalizedEmail = "daoquockhanh280998@gmail.co",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                FistName = "Khánh",
                LastName="Đào",
                DOB= new DateTime(2020,5,28)
            }) ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleID,
                UserId = adminID
            });
            #endregion



        }
    }
}
