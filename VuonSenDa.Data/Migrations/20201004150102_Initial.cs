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
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_AdminAccountCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccounts", x => x.Id);
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
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.ArticleCategoryId);
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
                    CreateBy = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
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
                    DateCreate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 10, 4, 22, 1, 2, 496, DateTimeKind.Local).AddTicks(3379))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 4, 22, 1, 2, 501, DateTimeKind.Local).AddTicks(9870)),
                    UserId = table.Column<Guid>(nullable: false),
                    ShipName = table.Column<string>(maxLength: 200, nullable: false),
                    ShipAddress = table.Column<string>(maxLength: 200, nullable: false),
                    ShipEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ShipPhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
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
                    DateCreate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2020, 10, 4, 22, 1, 2, 510, DateTimeKind.Local).AddTicks(8772)),
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
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ExternalTransactionId = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    Result = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Provider = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: false),
                    SeoTitle = table.Column<string>(maxLength: 500, nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
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
                        principalColumn: "Id",
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
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductMainCategoryId",
                table: "ProductCategories",
                column: "ProductMainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAccountCategorys");

            migrationBuilder.DropTable(
                name: "AdminAccounts");

            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "ArticleMainCategories");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CategoryTranslations");

            migrationBuilder.DropTable(
                name: "ClientAccounts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductMainCategories");
        }
    }
}
