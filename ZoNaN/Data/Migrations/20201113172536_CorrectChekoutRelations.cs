using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoNaN.Data.Migrations
{
    public partial class CorrectChekoutRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Chekouts_CheckoutId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Chekouts_ChekoutId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ChekoutId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_CheckoutId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ChekoutId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CheckoutId",
                table: "Baskets");

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Chekouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Chekouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chekouts_BasketId",
                table: "Chekouts",
                column: "BasketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chekouts_CustomerId",
                table: "Chekouts",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chekouts_Baskets_BasketId",
                table: "Chekouts",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chekouts_Customers_CustomerId",
                table: "Chekouts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chekouts_Baskets_BasketId",
                table: "Chekouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Chekouts_Customers_CustomerId",
                table: "Chekouts");

            migrationBuilder.DropIndex(
                name: "IX_Chekouts_BasketId",
                table: "Chekouts");

            migrationBuilder.DropIndex(
                name: "IX_Chekouts_CustomerId",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Chekouts");

            migrationBuilder.AddColumn<int>(
                name: "ChekoutId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CheckoutId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ChekoutId",
                table: "Customers",
                column: "ChekoutId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CheckoutId",
                table: "Baskets",
                column: "CheckoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Chekouts_CheckoutId",
                table: "Baskets",
                column: "CheckoutId",
                principalTable: "Chekouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Chekouts_ChekoutId",
                table: "Customers",
                column: "ChekoutId",
                principalTable: "Chekouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
