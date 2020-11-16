using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class SubscribersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 15, 17, 44, 50, 767, DateTimeKind.Local).AddTicks(3387),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 15, 2, 10, 12, 738, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 15, 2, 10, 12, 738, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 15, 17, 44, 50, 767, DateTimeKind.Local).AddTicks(3387));
        }
    }
}
