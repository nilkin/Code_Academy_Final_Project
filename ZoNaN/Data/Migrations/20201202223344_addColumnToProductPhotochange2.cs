using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class addColumnToProductPhotochange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 2, 33, 43, 844, DateTimeKind.Local).AddTicks(8123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 2, 32, 17, 572, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.AlterColumn<string>(
                name: "IsSecondPhoto",
                table: "ProductPhotos",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "False",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "IsFirstPhoto",
                table: "ProductPhotos",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "False",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 2, 33, 43, 819, DateTimeKind.Local).AddTicks(9169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 2, 32, 17, 548, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 2, 33, 43, 830, DateTimeKind.Local).AddTicks(4974),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 3, 2, 32, 17, 557, DateTimeKind.Local).AddTicks(6989));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 2, 32, 17, 572, DateTimeKind.Local).AddTicks(2229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 2, 33, 43, 844, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.AlterColumn<bool>(
                name: "IsSecondPhoto",
                table: "ProductPhotos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "False");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFirstPhoto",
                table: "ProductPhotos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "False");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 2, 32, 17, 548, DateTimeKind.Local).AddTicks(1793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 2, 33, 43, 819, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 2, 32, 17, 557, DateTimeKind.Local).AddTicks(6989),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 3, 2, 33, 43, 830, DateTimeKind.Local).AddTicks(4974));
        }
    }
}
