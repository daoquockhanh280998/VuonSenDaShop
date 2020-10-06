using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopOnlineGamingPC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDaShop.Data.Configurations;
using VuonSenDaShop.Data.Configurations.Translation;
using VuonSenDaShop.Data.Entities;
using VuonSenDaShop.Data.Extensions;

namespace VuonSenDaShop.Data.EF
{
    public class VuonSenDaShopDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public VuonSenDaShopDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

            modelBuilder.ApplyConfiguration(new AdminAccountConfiguration());
            modelBuilder.ApplyConfiguration(new AdminAccountCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ArticleConfiguration());
            modelBuilder.ApplyConfiguration(new ArticleCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ArticleMainCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new ClientAccountConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());

            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

            modelBuilder.ApplyConfiguration(new PictureConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMainCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            #region TranSlation
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMainCategoryTranslationConfiguration());
            #endregion

            #region Data seeding
            modelBuilder.Seed();
            #endregion

            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
        }
        public DbSet<AdminAccount> AdminAccounts { get; set; }
        public DbSet<AdminAccountCategory> AdminAccountCategories { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ArticleMainCategory> ArticleMainCategories { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<ClientAccount> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductMainCategory> ProductMainCategories { get; set; }

        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<ProductCategoryTranslation> ProductCategorieTranslations { get; set; }
        public DbSet<ProductMainCategoryTranslation> ProductMainCategoryTranslations { get; set; }



        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }





    }
}
