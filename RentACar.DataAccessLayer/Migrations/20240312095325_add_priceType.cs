using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class add_priceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PriceType",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceType",
                table: "Prices");
        }
    }
}
