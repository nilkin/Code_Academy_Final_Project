using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class changeRelationsProdBasketChekoutTablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropColumn(
                name: "IsGuest",
                table: "Chekouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 3, 6, 58, 328, DateTimeKind.Local).AddTicks(8192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 2, 15, 38, 41, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 3, 6, 58, 263, DateTimeKind.Local).AddTicks(7521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 2, 15, 37, 967, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Chekouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Chekouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Chekouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Chekouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Chekouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Chekouts",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Chekouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 3, 6, 58, 293, DateTimeKind.Local).AddTicks(2677),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 2, 15, 38, 5, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.CreateTable(
                name: "ChekoutProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ChekoutId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChekoutProducts", x => new { x.ChekoutId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ChekoutProducts_Chekouts_ChekoutId",
                        column: x => x.ChekoutId,
                        principalTable: "Chekouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChekoutProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChekoutProducts_ProductId",
                table: "ChekoutProducts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChekoutProducts");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Chekouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 2, 15, 38, 41, DateTimeKind.Local).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 3, 6, 58, 328, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 25, 2, 15, 37, 967, DateTimeKind.Local).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 25, 3, 6, 58, 263, DateTimeKind.Local).AddTicks(7521));

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
                defaultValue: new DateTime(2020, 11, 25, 2, 15, 38, 5, DateTimeKind.Local).AddTicks(2190),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2020, 11, 25, 3, 6, 58, 293, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isCart = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    isCompare = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    isWish = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });
        }
    }
}
