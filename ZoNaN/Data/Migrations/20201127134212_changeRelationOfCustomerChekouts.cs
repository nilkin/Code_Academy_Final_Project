using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class changeRelationOfCustomerChekouts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chekouts_CustomerId",
                table: "Chekouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 27, 17, 42, 11, 771, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 26, 23, 10, 44, 940, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 27, 17, 42, 11, 685, DateTimeKind.Local).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 26, 23, 10, 44, 916, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 27, 17, 42, 11, 722, DateTimeKind.Local).AddTicks(1520),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 26, 23, 10, 44, 929, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.CreateIndex(
                name: "IX_Chekouts_CustomerId",
                table: "Chekouts",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chekouts_CustomerId",
                table: "Chekouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 26, 23, 10, 44, 940, DateTimeKind.Local).AddTicks(3159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 27, 17, 42, 11, 771, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 26, 23, 10, 44, 916, DateTimeKind.Local).AddTicks(3443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 27, 17, 42, 11, 685, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 26, 23, 10, 44, 929, DateTimeKind.Local).AddTicks(556),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 27, 17, 42, 11, 722, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.CreateIndex(
                name: "IX_Chekouts_CustomerId",
                table: "Chekouts",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");
        }
    }
}
