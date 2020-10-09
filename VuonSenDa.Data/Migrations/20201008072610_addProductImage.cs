using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class addProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dercription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Dercription",
                table: "ProductMainCategories");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "ProductMainCategories");

            migrationBuilder.DropColumn(
                name: "ProductMainCategoryName",
                table: "ProductMainCategories");

            migrationBuilder.DropColumn(
                name: "Dercription",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ProductCategoryName",
                table: "ProductCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 8, 14, 26, 9, 5, DateTimeKind.Local).AddTicks(361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 6, 10, 49, 15, 984, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 6, 10, 49, 15, 978, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 8, 14, 26, 8, 992, DateTimeKind.Local).AddTicks(5860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 6, 10, 49, 15, 973, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ed48c67-f62f-43df-ad4b-1ff27e5daf21"),
                column: "ConcurrencyStamp",
                value: "680c28df-47ab-4839-948a-512317fecb60");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("08f06ac0-5706-465e-ad7b-5bfa88117b00"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61032d03-edd8-4f30-bfb0-04f706f1d5dd", "AQAAAAEAACcQAAAAEBxSneRwYOcOpBxgJhi/nBj292ZEBYuiqPII8x1zi0OJVZZupsKgHJLJVHf7QE7qkw==" });

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
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 1,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { "Sen Dù Hồng 3-5cm (Chậu Nhựa)", "Sen Dù Hồng 3-5cm (Chậu Nhựa)" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 2,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { "Pink  Stone Lotus 3-5cm (Plastic Pots)", "Pink  Stone Lotus 3-5cm (Plastic Pots)" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 3,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { "Sen Dù Hồng 5-10cm ", "Sen Dù Hồng 5-10cm " });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 4,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { "Pink  Stone Lotus 5-10cm (Plastic Pots)", "Pink  Stone Lotus 5-10cm (Plastic Pots)" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 5,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) " });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 6,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { "Dragon Spirit Cactus 7-9cm (Plastic Pots) ", "Dragon Spirit Cactus 7-9cm (Plastic Pots)" });

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
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "Dercription",
                table: "Products",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Products",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dercription",
                table: "ProductMainCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "ProductMainCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductMainCategoryName",
                table: "ProductMainCategories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dercription",
                table: "ProductCategories",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductCategoryName",
                table: "ProductCategories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 6, 10, 49, 15, 984, DateTimeKind.Local).AddTicks(7385),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 8, 14, 26, 9, 5, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 6, 10, 49, 15, 978, DateTimeKind.Local).AddTicks(8592),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 6, 10, 49, 15, 973, DateTimeKind.Local).AddTicks(9571),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 8, 14, 26, 8, 992, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ed48c67-f62f-43df-ad4b-1ff27e5daf21"),
                column: "ConcurrencyStamp",
                value: "e6976900-9f3c-4d14-9514-efa1b9a3b963");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("08f06ac0-5706-465e-ad7b-5bfa88117b00"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "561c578a-a109-4d66-b7e6-0277049defd0", "AQAAAAEAACcQAAAAENSWgHnzxn3RTGnXipjZt6nPBTQwlcNrpyES6BGV6CfkTYU9yHnrsBWajFTn6rcEKw==" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1,
                columns: new[] { "Dercription", "ProductCategoryName", "Status" },
                values: new object[] { "Sen đá cỡ nhỏ", "Sen đá cỡ nhỏ", 1 });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 2,
                columns: new[] { "Dercription", "ProductCategoryName", "Status" },
                values: new object[] { "Sen đá cỡ Lớn", "Sen đá cỡ Lớn", 1 });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 3,
                columns: new[] { "Dercription", "ProductCategoryName", "Status" },
                values: new object[] { "Xương Rồng", "Xương Rồng", 1 });

            migrationBuilder.UpdateData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 1,
                columns: new[] { "Dercription", "ProductMainCategoryName", "Status" },
                values: new object[] { "Sen đá bịch/chậu nhựa", "Sen đá bịch/chậu nhựa", 1 });

            migrationBuilder.UpdateData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 2,
                columns: new[] { "Dercription", "ProductMainCategoryName", "Status" },
                values: new object[] { "Xương rồng", "Xương rồng", 1 });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 1,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 2,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 3,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 4,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 5,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 6,
                columns: new[] { "Dercription", "Details" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Dercription", "Details", "ProductName", "Status" },
                values: new object[] { "Sen Dù Hồng 3-5cm (Chậu Nhựa)", "Sen Dù Hồng 3-5cm (Chậu Nhựa)", "Sen Dù Hồng 3-5cm (Chậu Nhựa)", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Dercription", "Details", "ProductName", "Status" },
                values: new object[] { "Sen Dù Hồng 5-10cm ", "Sen Dù Hồng 5-10cm ", "Sen Dù Hồng 5-10cm ", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Dercription", "Details", "ProductName", "Status" },
                values: new object[] { "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", "Xương Rồng Thần Long 7-9cm (Chậu Nhựa) ", 1 });
        }
    }
}
