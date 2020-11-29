using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class updateContactMessageDataType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 17, 3, 46, 297, DateTimeKind.Local).AddTicks(7992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 726, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contacts",
                type: "ntext",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 17, 3, 46, 272, DateTimeKind.Local).AddTicks(9457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 702, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 17, 3, 46, 283, DateTimeKind.Local).AddTicks(7096),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 712, DateTimeKind.Local).AddTicks(8040));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 726, DateTimeKind.Local).AddTicks(6441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 17, 3, 46, 297, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contacts",
                type: "ntext",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 702, DateTimeKind.Local).AddTicks(6212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 17, 3, 46, 272, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 712, DateTimeKind.Local).AddTicks(8040),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 29, 17, 3, 46, 283, DateTimeKind.Local).AddTicks(7096));
        }
    }
}
