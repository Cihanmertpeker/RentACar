using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class mig_add_howitworksstep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "howItWorksSteps",
                columns: table => new
                {
                    HowItWorksStepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_howItWorksSteps", x => x.HowItWorksStepID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "howItWorksSteps");
        }
    }
}
