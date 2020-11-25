using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class AddRelationOfOrderAndChekoutUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotalPrice",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 13, 10, 45, 628, DateTimeKind.Local).AddTicks(5403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 780, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 13, 10, 45, 562, DateTimeKind.Local).AddTicks(7358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 714, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 13, 10, 45, 592, DateTimeKind.Local).AddTicks(6816),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 744, DateTimeKind.Local).AddTicks(7933));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 780, DateTimeKind.Local).AddTicks(9883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 13, 10, 45, 628, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotalPrice",
                table: "Orders",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 714, DateTimeKind.Local).AddTicks(8366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 13, 10, 45, 562, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 744, DateTimeKind.Local).AddTicks(7933),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 13, 10, 45, 592, DateTimeKind.Local).AddTicks(6816));
        }
    }
}
