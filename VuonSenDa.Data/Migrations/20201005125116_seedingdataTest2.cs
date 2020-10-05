using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class seedingdataTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 19, 51, 15, 734, DateTimeKind.Local).AddTicks(5266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 784, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 5, 19, 51, 15, 725, DateTimeKind.Local).AddTicks(2493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 774, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 19, 51, 15, 721, DateTimeKind.Local).AddTicks(4775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 768, DateTimeKind.Local).AddTicks(6965));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "ProductCategoryTranslations",
                keyColumn: "ProductCategoryTranslationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategoryTranslations",
                keyColumn: "ProductCategoryTranslationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategoryTranslations",
                keyColumn: "ProductCategoryTranslationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategoryTranslations",
                keyColumn: "ProductCategoryTranslationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategoryTranslations",
                keyColumn: "ProductCategoryTranslationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategoryTranslations",
                keyColumn: "ProductCategoryTranslationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductMainCategoryTranslations",
                keyColumn: "ProductMainCategoryTranslationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductMainCategoryTranslations",
                keyColumn: "ProductMainCategoryTranslationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductMainCategoryTranslations",
                keyColumn: "ProductMainCategoryTranslationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductMainCategoryTranslations",
                keyColumn: "ProductMainCategoryTranslationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductMainCategories",
                keyColumn: "ProductMainCategoryId",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 784, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 51, 15, 734, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 774, DateTimeKind.Local).AddTicks(64),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 51, 15, 725, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 768, DateTimeKind.Local).AddTicks(6965),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 51, 15, 721, DateTimeKind.Local).AddTicks(4775));
        }
    }
}
