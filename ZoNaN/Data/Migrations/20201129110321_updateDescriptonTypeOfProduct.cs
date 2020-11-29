using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class updateDescriptonTypeOfProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 720, DateTimeKind.Local).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 14, 59, 31, 509, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 696, DateTimeKind.Local).AddTicks(9784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 14, 59, 31, 475, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 706, DateTimeKind.Local).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 29, 14, 59, 31, 490, DateTimeKind.Local).AddTicks(276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 14, 59, 31, 509, DateTimeKind.Local).AddTicks(8896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 720, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 14, 59, 31, 475, DateTimeKind.Local).AddTicks(3948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 696, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 14, 59, 31, 490, DateTimeKind.Local).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 706, DateTimeKind.Local).AddTicks(5058));
        }
    }
}
