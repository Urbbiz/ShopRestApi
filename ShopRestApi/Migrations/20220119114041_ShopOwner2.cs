using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRestApi.Migrations
{
    public partial class ShopOwner2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwnerShop_ShopOwner_ShopOwnerId",
                table: "ShopOwnerShop");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwnerShop_Shops_ShopId",
                table: "ShopOwnerShop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopOwnerShop",
                table: "ShopOwnerShop");

            migrationBuilder.RenameTable(
                name: "ShopOwnerShop",
                newName: "shopOwnerShops");

            migrationBuilder.RenameIndex(
                name: "IX_ShopOwnerShop_ShopOwnerId",
                table: "shopOwnerShops",
                newName: "IX_shopOwnerShops_ShopOwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopOwnerShops",
                table: "shopOwnerShops",
                columns: new[] { "ShopId", "ShopOwnerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_shopOwnerShops_ShopOwner_ShopOwnerId",
                table: "shopOwnerShops",
                column: "ShopOwnerId",
                principalTable: "ShopOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shopOwnerShops_Shops_ShopId",
                table: "shopOwnerShops",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopOwnerShops_ShopOwner_ShopOwnerId",
                table: "shopOwnerShops");

            migrationBuilder.DropForeignKey(
                name: "FK_shopOwnerShops_Shops_ShopId",
                table: "shopOwnerShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopOwnerShops",
                table: "shopOwnerShops");

            migrationBuilder.RenameTable(
                name: "shopOwnerShops",
                newName: "ShopOwnerShop");

            migrationBuilder.RenameIndex(
                name: "IX_shopOwnerShops_ShopOwnerId",
                table: "ShopOwnerShop",
                newName: "IX_ShopOwnerShop_ShopOwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopOwnerShop",
                table: "ShopOwnerShop",
                columns: new[] { "ShopId", "ShopOwnerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwnerShop_ShopOwner_ShopOwnerId",
                table: "ShopOwnerShop",
                column: "ShopOwnerId",
                principalTable: "ShopOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwnerShop_Shops_ShopId",
                table: "ShopOwnerShop",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
