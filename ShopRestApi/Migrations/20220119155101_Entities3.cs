using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopRestApi.Migrations
{
    public partial class Entities3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ShopItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ShopItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ShopItems");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ShopItems");
        }
    }
}
