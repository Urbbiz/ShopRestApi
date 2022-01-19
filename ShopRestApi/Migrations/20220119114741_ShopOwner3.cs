using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRestApi.Migrations
{
    public partial class ShopOwner3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "ShopOwnerShops");

            migrationBuilder.RenameIndex(
                name: "IX_shopOwnerShops_ShopOwnerId",
                table: "ShopOwnerShops",
                newName: "IX_ShopOwnerShops_ShopOwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopOwnerShops",
                table: "ShopOwnerShops",
                columns: new[] { "ShopId", "ShopOwnerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwnerShops_ShopOwner_ShopOwnerId",
                table: "ShopOwnerShops",
                column: "ShopOwnerId",
                principalTable: "ShopOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwnerShops_Shops_ShopId",
                table: "ShopOwnerShops",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwnerShops_ShopOwner_ShopOwnerId",
                table: "ShopOwnerShops");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwnerShops_Shops_ShopId",
                table: "ShopOwnerShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopOwnerShops",
                table: "ShopOwnerShops");

            migrationBuilder.RenameTable(
                name: "ShopOwnerShops",
                newName: "shopOwnerShops");

            migrationBuilder.RenameIndex(
                name: "IX_ShopOwnerShops_ShopOwnerId",
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
    }
}
