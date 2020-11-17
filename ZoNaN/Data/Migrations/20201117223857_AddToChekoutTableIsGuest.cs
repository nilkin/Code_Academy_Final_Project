using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class AddToChekoutTableIsGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 2, 38, 56, 168, DateTimeKind.Local).AddTicks(7012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 18, 0, 8, 36, 388, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 2, 38, 56, 88, DateTimeKind.Local).AddTicks(9663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 18, 0, 8, 36, 361, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Chekouts",
                type: "ntext",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<bool>(
                name: "IsGuest",
                table: "Chekouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 2, 38, 56, 130, DateTimeKind.Local).AddTicks(6933),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 18, 0, 8, 36, 375, DateTimeKind.Local).AddTicks(7121));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGuest",
                table: "Chekouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 0, 8, 36, 388, DateTimeKind.Local).AddTicks(796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 18, 2, 38, 56, 168, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 0, 8, 36, 361, DateTimeKind.Local).AddTicks(541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 18, 2, 38, 56, 88, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Chekouts",
                type: "ntext",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 0, 8, 36, 375, DateTimeKind.Local).AddTicks(7121),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 18, 2, 38, 56, 130, DateTimeKind.Local).AddTicks(6933));
        }
    }
}
