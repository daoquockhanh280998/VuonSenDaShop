using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class updateIndentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 985, DateTimeKind.Local).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 241, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 974, DateTimeKind.Local).AddTicks(665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 230, DateTimeKind.Local).AddTicks(1745));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 241, DateTimeKind.Local).AddTicks(1076),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 985, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 230, DateTimeKind.Local).AddTicks(1745),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 12, 14, 4, 21, 974, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ed48c67-f62f-43df-ad4b-1ff27e5daf21"),
                column: "ConcurrencyStamp",
                value: "45650392-c68c-4e0b-a781-30f74a6d4e49");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("08f06ac0-5706-465e-ad7b-5bfa88117b00"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7671871-4325-43cb-9871-22e1dbbca45e", "AQAAAAEAACcQAAAAEIIW8+Ouph5fofYB1PFGtsrxtCPfS0c6OedTC1P6cCJBu9pDCZ1pvGOtq5rJGi/bNQ==" });

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
        }
    }
}
