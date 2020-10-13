using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class deleteAvatarAndThumb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Thumb",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 241, DateTimeKind.Local).AddTicks(1076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 8, 16, 8, 10, 573, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 230, DateTimeKind.Local).AddTicks(1745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 8, 16, 8, 10, 562, DateTimeKind.Local).AddTicks(9285));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Products",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Thumb",
                table: "Products",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 8, 16, 8, 10, 573, DateTimeKind.Local).AddTicks(7833),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 241, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 8, 16, 8, 10, 562, DateTimeKind.Local).AddTicks(9285),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 10, 16, 52, 56, 230, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ed48c67-f62f-43df-ad4b-1ff27e5daf21"),
                column: "ConcurrencyStamp",
                value: "d76e36db-099e-4dcb-8b43-52e6b1b3b910");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("08f06ac0-5706-465e-ad7b-5bfa88117b00"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d820ae9-ea0e-4aac-b131-736c762cab5d", "AQAAAAEAACcQAAAAEDoRlBNvhyj9ddARcXF8Mj2N5uph5Bfc4TnikZPtW4K0ED82yn40bffOmd0PT1YcKg==" });

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
                columns: new[] { "Avatar", "Status" },
                values: new object[] { "hinh", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Avatar", "Status" },
                values: new object[] { "hinh", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Avatar", "Status" },
                values: new object[] { "hinh", 1 });
        }
    }
}
