using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class ChangeUserPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 999999998);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "user",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 14, 2, 49, 120, DateTimeKind.Local).AddTicks(383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 13, 33, 49, 464, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 14, 2, 49, 50, DateTimeKind.Local).AddTicks(3532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 13, 33, 49, 392, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 14, 2, 49, 81, DateTimeKind.Local).AddTicks(2870),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 5, 13, 33, 49, 424, DateTimeKind.Local).AddTicks(6812));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "user");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 13, 33, 49, 464, DateTimeKind.Local).AddTicks(1340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 14, 2, 49, 120, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 13, 33, 49, 392, DateTimeKind.Local).AddTicks(9038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 14, 2, 49, 50, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 13, 33, 49, 424, DateTimeKind.Local).AddTicks(6812),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 5, 14, 2, 49, 81, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Lastname", "Name", "Password", "Token" },
                values: new object[] { 999999998, "admin@mail.com", "admin", "admin", "AQAAAAEAACcQAAAAEPFBEHcudvFHnRPhntVlXk/nwgnxHAf+c1oVJaoJNwOt3cNdDQPKjKX4dI+aN8BNUA==", "AQAAAAEAACcQAAAAEIQkMwpUcTMKwdYPY9ujciKM3zzYaDi7SAuE4niZpMamCQyZnFySZ7Dsly7s3xw93w==" });
        }
    }
}
