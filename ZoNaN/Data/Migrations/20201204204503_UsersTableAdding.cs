using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class UsersTableAdding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 45, 2, 400, DateTimeKind.Local).AddTicks(678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 167, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 45, 2, 311, DateTimeKind.Local).AddTicks(3653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 93, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 45, 2, 351, DateTimeKind.Local).AddTicks(1999),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 126, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Token = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValue: "avatar.png"),
                    Position = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 167, DateTimeKind.Local).AddTicks(390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 45, 2, 400, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 93, DateTimeKind.Local).AddTicks(7052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 45, 2, 311, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 5, 0, 39, 37, 126, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 12, 5, 0, 45, 2, 351, DateTimeKind.Local).AddTicks(1999));
        }
    }
}
