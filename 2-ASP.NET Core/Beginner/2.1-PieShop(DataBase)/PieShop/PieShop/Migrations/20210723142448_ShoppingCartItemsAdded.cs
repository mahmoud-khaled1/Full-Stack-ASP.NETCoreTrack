using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class ShoppingCartItemsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pies_Categories_CategoryId",
                table: "pies");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItem_pies_PieId",
                table: "ShoppingCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pies",
                table: "pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItem",
                table: "ShoppingCartItem");

            migrationBuilder.RenameTable(
                name: "pies",
                newName: "Pies");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItem",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_pies_CategoryId",
                table: "Pies",
                newName: "IX_Pies_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItem_PieId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "Pies",
                newName: "pies");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCartItem");

            migrationBuilder.RenameIndex(
                name: "IX_Pies_CategoryId",
                table: "pies",
                newName: "IX_pies_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_PieId",
                table: "ShoppingCartItem",
                newName: "IX_ShoppingCartItem_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pies",
                table: "pies",
                column: "PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItem",
                table: "ShoppingCartItem",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_pies_Categories_CategoryId",
                table: "pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItem_pies_PieId",
                table: "ShoppingCartItem",
                column: "PieId",
                principalTable: "pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
