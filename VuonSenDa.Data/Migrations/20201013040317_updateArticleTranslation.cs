using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class updateArticleTranslation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleCategories_ArticleMainCategories_ArticleMainCategoryId",
                table: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "ArticleMainCategories");

            migrationBuilder.DropIndex(
                name: "IX_ArticleCategories_ArticleMainCategoryId",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "ArticleName",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Dercription",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Thumb",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleCategoryName",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "ArticleMainCategoryId",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "Dercription",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "Thumb",
                table: "ArticleCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 13, 11, 3, 15, 998, DateTimeKind.Local).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 985, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 13, 11, 3, 15, 986, DateTimeKind.Local).AddTicks(7599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 974, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.CreateTable(
                name: "ArticleCategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleCategoryTranslationName = table.Column<string>(maxLength: 200, nullable: false),
                    Title = table.Column<string>(maxLength: 400, nullable: false),
                    Dercription = table.Column<string>(maxLength: 1000, nullable: true),
                    Details = table.Column<string>(maxLength: 4000, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    ArticleCategoryId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleCategoryTranslations_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalTable: "ArticleCategories",
                        principalColumn: "ArticleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleImages_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleTranslationName = table.Column<string>(maxLength: 400, nullable: false),
                    Title = table.Column<string>(maxLength: 400, nullable: false),
                    Dercription = table.Column<string>(maxLength: 1000, nullable: true),
                    Details = table.Column<string>(maxLength: 4000, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    ArticleId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleTranslations_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ed48c67-f62f-43df-ad4b-1ff27e5daf21"),
                column: "ConcurrencyStamp",
                value: "11ce5b35-8268-4b66-848f-b368f614d8fe");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("08f06ac0-5706-465e-ad7b-5bfa88117b00"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6836cb07-2260-4eb2-95b8-366231ef3ff1", "AQAAAAEAACcQAAAAEDXHDwVyMYeDZSKOloM5pJXMa+lmCtMl6rsnSCwT3Z/ZeXwDRTWVRbU3XmR2j8eIGA==" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategoryTranslations_ArticleCategoryId",
                table: "ArticleCategoryTranslations",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategoryTranslations_LanguageId",
                table: "ArticleCategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImages_ArticleId",
                table: "ArticleImages",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTranslations_ArticleId",
                table: "ArticleTranslations",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTranslations_LanguageId",
                table: "ArticleTranslations",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategoryTranslations");

            migrationBuilder.DropTable(
                name: "ArticleImages");

            migrationBuilder.DropTable(
                name: "ArticleTranslations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 985, DateTimeKind.Local).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 13, 11, 3, 15, 998, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 974, DateTimeKind.Local).AddTicks(665),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 13, 11, 3, 15, 986, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.AddColumn<string>(
                name: "ArticleName",
                table: "Articles",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Articles",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dercription",
                table: "Articles",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumb",
                table: "Articles",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArticleCategoryName",
                table: "ArticleCategories",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ArticleMainCategoryId",
                table: "ArticleCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "ArticleCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dercription",
                table: "ArticleCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumb",
                table: "ArticleCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArticleMainCategories",
                columns: table => new
                {
                    ArticleMainCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleMainCategoryName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dercription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Thumb = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleMainCategories", x => x.ArticleMainCategoryId);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ed48c67-f62f-43df-ad4b-1ff27e5daf21"),
                column: "ConcurrencyStamp",
                value: "60025991-9a36-4b69-a03d-e5101d213610");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("08f06ac0-5706-465e-ad7b-5bfa88117b00"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7052e787-ba76-435c-a040-0acdcde914b1", "AQAAAAEAACcQAAAAEG0zR6DYq/Gulee8h4NpEOTN1qiu4TaLlIYCMSQb+pA31az2Ljqk+8TbO6TpZDUFWA==" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_ArticleMainCategoryId",
                table: "ArticleCategories",
                column: "ArticleMainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleCategories_ArticleMainCategories_ArticleMainCategoryId",
                table: "ArticleCategories",
                column: "ArticleMainCategoryId",
                principalTable: "ArticleMainCategories",
                principalColumn: "ArticleMainCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
