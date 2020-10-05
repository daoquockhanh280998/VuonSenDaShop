using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class seedingdataTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "Dercription",
                table: "ProductMainCategoryTranslations");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "ProductMainCategoryTranslations");

            migrationBuilder.DropColumn(
                name: "ProductMainCategoryName",
                table: "ProductMainCategoryTranslations");

            migrationBuilder.DropColumn(
                name: "ProductCategoryName",
                table: "ProductCategoryTranslations");

            migrationBuilder.AddColumn<string>(
                name: "ProductTranslationName",
                table: "ProductTranslations",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductMainCategoryTranslationName",
                table: "ProductMainCategoryTranslations",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductCategoryTranslationName",
                table: "ProductCategoryTranslations",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 784, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 313, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 774, DateTimeKind.Local).AddTicks(64),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 304, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 768, DateTimeKind.Local).AddTicks(6965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 300, DateTimeKind.Local).AddTicks(8682));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductTranslationName",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "ProductMainCategoryTranslationName",
                table: "ProductMainCategoryTranslations");

            migrationBuilder.DropColumn(
                name: "ProductCategoryTranslationName",
                table: "ProductCategoryTranslations");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ProductTranslations",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dercription",
                table: "ProductMainCategoryTranslations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "ProductMainCategoryTranslations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductMainCategoryName",
                table: "ProductMainCategoryTranslations",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductCategoryName",
                table: "ProductCategoryTranslations",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 313, DateTimeKind.Local).AddTicks(5987),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 784, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 304, DateTimeKind.Local).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 774, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 300, DateTimeKind.Local).AddTicks(8682),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 19, 44, 26, 768, DateTimeKind.Local).AddTicks(6965));
        }
    }
}
