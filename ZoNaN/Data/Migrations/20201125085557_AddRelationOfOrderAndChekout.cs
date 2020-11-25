using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class AddRelationOfOrderAndChekout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChekoutProducts_Products_ProductId",
                table: "ChekoutProducts");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ChekoutProducts",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ChekoutProducts_ProductId",
                table: "ChekoutProducts",
                newName: "IX_ChekoutProducts_OrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 780, DateTimeKind.Local).AddTicks(9883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 5, 14, 22, 103, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 714, DateTimeKind.Local).AddTicks(8366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 5, 14, 22, 76, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 744, DateTimeKind.Local).AddTicks(7933),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 5, 14, 22, 88, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.AddForeignKey(
                name: "FK_ChekoutProducts_Orders_OrderId",
                table: "ChekoutProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChekoutProducts_Orders_OrderId",
                table: "ChekoutProducts");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ChekoutProducts",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ChekoutProducts_OrderId",
                table: "ChekoutProducts",
                newName: "IX_ChekoutProducts_ProductId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 5, 14, 22, 103, DateTimeKind.Local).AddTicks(3745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 780, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 5, 14, 22, 76, DateTimeKind.Local).AddTicks(9637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 714, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 5, 14, 22, 88, DateTimeKind.Local).AddTicks(1448),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 12, 55, 56, 744, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.AddForeignKey(
                name: "FK_ChekoutProducts_Products_ProductId",
                table: "ChekoutProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
