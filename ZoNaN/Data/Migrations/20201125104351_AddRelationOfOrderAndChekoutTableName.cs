using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class AddRelationOfOrderAndChekoutTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChekoutProducts_Chekouts_ChekoutId",
                table: "ChekoutProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ChekoutProducts_Orders_OrderId",
                table: "ChekoutProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChekoutProducts",
                table: "ChekoutProducts");

            migrationBuilder.RenameTable(
                name: "ChekoutProducts",
                newName: "OderChekouts");

            migrationBuilder.RenameIndex(
                name: "IX_ChekoutProducts_OrderId",
                table: "OderChekouts",
                newName: "IX_OderChekouts_OrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 14, 43, 50, 771, DateTimeKind.Local).AddTicks(3761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 14, 41, 59, 381, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 14, 43, 50, 750, DateTimeKind.Local).AddTicks(6962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 14, 41, 59, 360, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 14, 43, 50, 760, DateTimeKind.Local).AddTicks(357),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 14, 41, 59, 370, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OderChekouts",
                table: "OderChekouts",
                columns: new[] { "ChekoutId", "OrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OderChekouts_Chekouts_ChekoutId",
                table: "OderChekouts",
                column: "ChekoutId",
                principalTable: "Chekouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OderChekouts_Orders_OrderId",
                table: "OderChekouts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderChekouts_Chekouts_ChekoutId",
                table: "OderChekouts");

            migrationBuilder.DropForeignKey(
                name: "FK_OderChekouts_Orders_OrderId",
                table: "OderChekouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OderChekouts",
                table: "OderChekouts");

            migrationBuilder.RenameTable(
                name: "OderChekouts",
                newName: "ChekoutProducts");

            migrationBuilder.RenameIndex(
                name: "IX_OderChekouts_OrderId",
                table: "ChekoutProducts",
                newName: "IX_ChekoutProducts_OrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 14, 41, 59, 381, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 14, 43, 50, 771, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 14, 41, 59, 360, DateTimeKind.Local).AddTicks(9427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 14, 43, 50, 750, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 14, 41, 59, 370, DateTimeKind.Local).AddTicks(2380),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 14, 43, 50, 760, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChekoutProducts",
                table: "ChekoutProducts",
                columns: new[] { "ChekoutId", "OrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChekoutProducts_Chekouts_ChekoutId",
                table: "ChekoutProducts",
                column: "ChekoutId",
                principalTable: "Chekouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChekoutProducts_Orders_OrderId",
                table: "ChekoutProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
