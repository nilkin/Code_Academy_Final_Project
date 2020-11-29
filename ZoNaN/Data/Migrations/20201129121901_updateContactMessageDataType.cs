using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class updateContactMessageDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 726, DateTimeKind.Local).AddTicks(6441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 720, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contacts",
                type: "ntext",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 702, DateTimeKind.Local).AddTicks(6212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 696, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 712, DateTimeKind.Local).AddTicks(8040),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 706, DateTimeKind.Local).AddTicks(5058));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 720, DateTimeKind.Local).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 726, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contacts",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 696, DateTimeKind.Local).AddTicks(9784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 702, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 29, 15, 3, 20, 706, DateTimeKind.Local).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 29, 16, 19, 0, 712, DateTimeKind.Local).AddTicks(8040));
        }
    }
}
