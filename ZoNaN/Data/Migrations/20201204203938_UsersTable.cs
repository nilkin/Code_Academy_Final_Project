using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class UsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 167, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 846, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 93, DateTimeKind.Local).AddTicks(7052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 820, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 126, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 831, DateTimeKind.Local).AddTicks(7617));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 846, DateTimeKind.Local).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 167, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 820, DateTimeKind.Local).AddTicks(1825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 93, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 1, 8, 48, 831, DateTimeKind.Local).AddTicks(7617),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 126, DateTimeKind.Local).AddTicks(3383));
        }
    }
}
