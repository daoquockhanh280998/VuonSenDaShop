using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuonSenDaShop.Data.Migrations
{
    public partial class DeleteAdminAccountToSql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminAccountIdName",
                table: "AdminAccounts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 313, DateTimeKind.Local).AddTicks(5987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 16, 54, 498, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 304, DateTimeKind.Local).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 16, 54, 488, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 300, DateTimeKind.Local).AddTicks(8682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 16, 54, 484, DateTimeKind.Local).AddTicks(5651));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Pictures",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 15, 16, 54, 498, DateTimeKind.Local).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 313, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 5, 15, 16, 54, 488, DateTimeKind.Local).AddTicks(6726),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 304, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 5, 15, 16, 54, 484, DateTimeKind.Local).AddTicks(5651),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 5, 15, 20, 4, 300, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.AddColumn<string>(
                name: "AdminAccountIdName",
                table: "AdminAccounts",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
