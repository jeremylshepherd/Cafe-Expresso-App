using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeAPI.Migrations
{
    public partial class PriceAddedInSubMenuModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "SubMenus",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SubMenus");
        }
    }
}
