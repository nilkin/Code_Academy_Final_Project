using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class ChangeRelationOfStockProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_StockId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 846, DateTimeKind.Local).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 5, 13, 31, 374, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 820, DateTimeKind.Local).AddTicks(1825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 5, 13, 31, 297, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 831, DateTimeKind.Local).AddTicks(7617),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 3, 5, 13, 31, 328, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockId",
                table: "Products",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_StockId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 5, 13, 31, 374, DateTimeKind.Local).AddTicks(1834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 846, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 5, 13, 31, 297, DateTimeKind.Local).AddTicks(1716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 820, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 5, 13, 31, 328, DateTimeKind.Local).AddTicks(546),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 831, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockId",
                table: "Products",
                column: "StockId",
                unique: true);
        }
    }
}
