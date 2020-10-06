using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminAccountCategorys",
                columns: table => new
                {
                    AdminAccountCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccountCategorys", x => x.AdminAccountCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FistName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    DOB = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ArticleMainCategories",
                columns: table => new
                {
                    ArticleMainCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleMainCategoryName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Dercription = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Position = table.Column<int>(nullable: false, defaultValue: 1),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleMainCategories", x => x.ArticleMainCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ClientAccounts",
                columns: table => new
                {
                    ClientAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    FullName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    PhoneNumber = table.Column<int>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 4000, nullable: true),
                    Gender = table.Column<int>(nullable: false, defaultValue: 0),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccounts", x => x.ClientAccountId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    FullName = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Content = table.Column<string>(maxLength: 4000, nullable: false),
                    PhoneNumber = table.Column<int>(maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 10, 6, 10, 32, 29, 823, DateTimeKind.Local).AddTicks(8126))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureName = table.Column<string>(maxLength: 500, nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: false),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 10, 6, 10, 32, 29, 834, DateTimeKind.Local).AddTicks(1575)),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureId);
                });

            migrationBuilder.CreateTable(
                name: "ProductMainCategories",
                columns: table => new
                {
                    ProductMainCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductMainCategoryName = table.Column<string>(maxLength: 500, nullable: false),
                    Dercription = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: false),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMainCategories", x => x.ProductMainCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    ApplyForAll = table.Column<bool>(nullable: false),
                    DiscountPercent = table.Column<int>(nullable: true),
                    DiscountAmount = table.Column<decimal>(nullable: true),
                    ProductIds = table.Column<string>(nullable: true),
                    ProductCategoryIds = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "AdminAccounts",
                columns: table => new
                {
                    AdminAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    FullName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 4000, nullable: true),
                    Gender = table.Column<int>(nullable: false, defaultValue: 0),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true),
                    AdminAccountCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccounts", x => x.AdminAccountId);
                    table.ForeignKey(
                        name: "FK_AdminAccounts_AdminAccountCategorys_AdminAccountCategoryId",
                        column: x => x.AdminAccountCategoryId,
                        principalTable: "AdminAccountCategorys",
                        principalColumn: "AdminAccountCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 6, 10, 32, 29, 828, DateTimeKind.Local).AddTicks(310)),
                    UserId = table.Column<Guid>(nullable: false),
                    ShipName = table.Column<string>(maxLength: 200, nullable: false),
                    ShipAddress = table.Column<string>(maxLength: 200, nullable: false),
                    ShipEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ShipPhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ExternalTransactionId = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    Result = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Provider = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transaction_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    ArticleCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleCategoryName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Dercription = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Position = table.Column<int>(nullable: false, defaultValue: 1),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true),
                    ArticleMainCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.ArticleCategoryId);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_ArticleMainCategories_ArticleMainCategoryId",
                        column: x => x.ArticleMainCategoryId,
                        principalTable: "ArticleMainCategories",
                        principalColumn: "ArticleMainCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryName = table.Column<string>(maxLength: 500, nullable: false),
                    Dercription = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: false),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true),
                    ProductMainCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductMainCategories_ProductMainCategoryId",
                        column: x => x.ProductMainCategoryId,
                        principalTable: "ProductMainCategories",
                        principalColumn: "ProductMainCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMainCategoryTranslations",
                columns: table => new
                {
                    ProductMainCategoryTranslationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductMainCategoryTranslationName = table.Column<string>(maxLength: 200, nullable: false),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    ProductMainCategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMainCategoryTranslations", x => x.ProductMainCategoryTranslationId);
                    table.ForeignKey(
                        name: "FK_ProductMainCategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMainCategoryTranslations_ProductMainCategories_ProductMainCategoryId",
                        column: x => x.ProductMainCategoryId,
                        principalTable: "ProductMainCategories",
                        principalColumn: "ProductMainCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Dercription = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: true),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    ViewTime = table.Column<int>(maxLength: 50, nullable: false),
                    ViewCount = table.Column<int>(maxLength: 50, nullable: false),
                    Position = table.Column<int>(nullable: false, defaultValue: 1),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true),
                    ArticleCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalTable: "ArticleCategories",
                        principalColumn: "ArticleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryTranslations",
                columns: table => new
                {
                    ProductCategoryTranslationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryTranslationName = table.Column<string>(maxLength: 200, nullable: false),
                    Dercription = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryTranslations", x => x.ProductCategoryTranslationId);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslations_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Details = table.Column<string>(maxLength: 4000, nullable: true),
                    Dercription = table.Column<string>(maxLength: 4000, nullable: true),
                    Avatar = table.Column<string>(maxLength: 4000, nullable: false),
                    Thumb = table.Column<string>(maxLength: 4000, nullable: true),
                    Stock = table.Column<int>(nullable: false, defaultValue: 0),
                    ViewTime = table.Column<int>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    ProductTranslationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTranslationName = table.Column<string>(maxLength: 200, nullable: false),
                    Dercription = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => x.ProductTranslationId);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of Vuon Sen Da" },
                    { "HomeKeyword", "This is keyword of Vuon Sen Da" },
                    { "HomeDescription", "This is description of Vuon Sen Da" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "ProductMainCategories",
                columns: new[] { "ProductMainCategoryId", "Avatar", "CreateBy", "DateCreate", "Dercription", "Position", "ProductMainCategoryName", "Status", "Thumb" },
                values: new object[,]
                {
                    { 1, "hinh", "Admin", null, "Sen đá bịch/chậu nhựa", 0, "Sen đá bịch/chậu nhựa", 1, null },
                    { 2, "hinh", "Admin", null, "Xương rồng", 0, "Xương rồng", 1, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "Avatar", "CreateBy", "DateCreate", "Dercription", "Position", "ProductCategoryName", "ProductMainCategoryId", "Status", "Thumb" },
                values: new object[,]
                {
                    { 1, "hinh", "Admin", null, "Sen đá cỡ nhỏ", 0, "Sen đá cỡ nhỏ", 1, 1, null },
                    { 2, "hinh", "Admin", null, "Sen đá cỡ Lớn", 0, "Sen đá cỡ Lớn", 1, 1, null },
                    { 3, "hinh", "Admin", null, "Xương Rồng", 0, "Xương Rồng", 2, 1, null }
                });

            migrationBuilder.InsertData(
                table: "ProductMainCategoryTranslations",
                columns: new[] { "ProductMainCategoryTranslationId", "LanguageId", "ProductMainCategoryId", "ProductMainCategoryTranslationName", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "vi-VN", 1, "Sen đá bịch/chậu nhựa", "sen-da-bich-chau-nhua", "Sen đá bịch/chậu nhựa", "Sen đá bịch/chậu nhựa" },
                    { 2, "en-US", 1, "Stone Lotus Plastic Pots", "Stone-Lotus-Plastic-Pots", "Stone-Lotus-Plastic-Pots", "Stone-Lotus-Plastic-Pots" },
                    { 3, "vi-VN", 2, "Xương rồng", "Xuong-Rong", "Xương rồng", "Xương rồng" },
                    { 4, "en-US", 2, "Cactus", "Cactus", "Cactus", "Cactus" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategoryTranslations",
                columns: new[] { "ProductCategoryTranslationId", "Dercription", "Details", "LanguageId", "ProductCategoryId", "ProductCategoryTranslationName", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, null, null, "vi-VN", 1, "Sen đá cỡ nhỏ", "sen-da-co-nho", "Sen đá cỡ nhỏ", "Sen đá cỡ nhỏ" },
                    { 2, null, null, "en-US", 1, "Small Stone Lotus", "Small-Stone-Lotus", "Small Stone Lotus", "Small Stone Lotus" },
                    { 3, null, null, "vi-VN", 2, "Sen đá cỡ Lớn", "Sen-Da-Co-Lon", "Sen đá cỡ Lớn", "Sen đá cỡ Lớn" },
                    { 4, null, null, "en-US", 2, "Big Stone Lotus", "Big-Stone-Lotus", "Big Stone Lotus", "Big Stone Lotus" },
                    { 5, null, null, "vi-VN", 3, "Xương Rồng", "Xuong-Rong", "Sen đá cỡ Lớn", "Sen đá cỡ Lớn" },
                    { 6, null, null, "en-US", 3, "Cactus", "Cactus", "Cactus", "Cactus" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Avatar", "CreateBy", "DateCreate", "Dercription", "Details", "OriginalPrice", "Position", "Price", "ProductCategoryId", "ProductName", "Status", "Thumb", "ViewCount", "ViewTime" },
                values: new object[,]
                {
                    { 1, "hinh", "Admin", null, "Sen Dù Hồng 3-5cm (Chậu Nhựa)", "Sen Dù Hồng 3-5cm (Chậu Nhựa)", 25000m, 0, 20000m, 1, "Sen Dù Hồng 3-5cm (Chậu Nhựa)", 1, null, 0, 0 },
                    { 2, "hinh", "Admin", null, "Sen Dù Hồng 5-10cm ", "Sen Dù Hồng 5-10cm ", 45000m, 0, 40000m, 2, "Sen Dù Hồng 5-10cm ", 1, null, 0, 0 },
                    { 3, "hinh", "Admin", null, "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", 55000m, 0, 50000m, 3, "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", 1, null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "ProductTranslationId", "Dercription", "Details", "LanguageId", "ProductId", "ProductTranslationName", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, null, null, "vi-VN", 1, "Sen Dù Hồng 3-5cm (Chậu Nhựa)", "sen-du-hong-3-5cm", "Sen Dù Hồng 3-5cm (Chậu Nhựa)", "Sen Dù Hồng 3-5cm (Chậu Nhựa)" },
                    { 2, null, null, "en-US", 1, "Stone Lotus Du Hong 3-5cm (Plastic pots)", "Stone-Lotus-Du-Hong-3-5cm-(Plastic-pots)", "Stone Lotus Du Hong 3-5cm (Plastic pots)", "Stone Lotus Du Hong 3-5cm (Plastic pots)" },
                    { 3, null, null, "vi-VN", 2, "Sen Dù Hồng 5-10cm ", "sen-du-hong-3-5cm", "Sen Dù Hồng 3-5cm ", "Sen Dù Hồng 3-5cm " },
                    { 4, null, null, "en-US", 2, "Stone Lotus Du Hong 5-10cm ", "Stone-Lotus-Du-Hong-5-10cm", "Stone Lotus Du Hong 5-10cm", "Stone Lotus Du Hong 5-10cm" },
                    { 5, null, null, "vi-VN", 3, "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", "xuong-rong-than-long", "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) " },
                    { 6, null, null, "en-US", 3, "Dragon Spirit Cactus 7-9cm (Plastic Pots)", "Dragon-Spirit-Cactus-7-9cm-Plastic Pots", "Dragon Spirit Cactus 7-9cm (Plastic Pots)", "Dragon Spirit Cactus 7-9cm (Plastic Pots)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminAccounts_AdminAccountCategoryId",
                table: "AdminAccounts",
                column: "AdminAccountCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_ArticleMainCategoryId",
                table: "ArticleCategories",
                column: "ArticleMainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductMainCategoryId",
                table: "ProductCategories",
                column: "ProductMainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslations_LanguageId",
                table: "ProductCategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslations_ProductCategoryId",
                table: "ProductCategoryTranslations",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMainCategoryTranslations_LanguageId",
                table: "ProductMainCategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMainCategoryTranslations_ProductMainCategoryId",
                table: "ProductMainCategoryTranslations",
                column: "ProductMainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "ProductTranslations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAccounts");

            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ClientAccounts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "ProductCategoryTranslations");

            migrationBuilder.DropTable(
                name: "ProductMainCategoryTranslations");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "AdminAccountCategorys");

            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ArticleMainCategories");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductMainCategories");
        }
    }
}
