using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.DataAccessLayer.Migrations
{
    public partial class mig_revise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDetails_AspNetUsers_AppUserID",
                table: "CarDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarCategories_CarCategoryID",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "howItWorksSteps");

            migrationBuilder.DropIndex(
                name: "IX_CarDetails_AppUserID",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "Services",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "CarStatusName",
                table: "CarStatuses",
                newName: "StatusName");

            migrationBuilder.RenameColumn(
                name: "Km",
                table: "Cars",
                newName: "km");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Cars",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "GearType",
                table: "Cars",
                newName: "Gear");

            migrationBuilder.RenameColumn(
                name: "CarModel",
                table: "Cars",
                newName: "GasType");

            migrationBuilder.RenameColumn(
                name: "CarCategoryID",
                table: "Cars",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarCategoryID",
                table: "Cars",
                newName: "IX_Cars_CategoryID");

            migrationBuilder.RenameColumn(
                name: "CarDetailID",
                table: "CarDetails",
                newName: "CarDetailId");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "AspNetUsers",
                newName: "NameSurname");

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "RentPrice",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature1 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature2 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature3 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature4 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature5 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature6 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature7 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature8 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature9 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature10 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature11 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature12 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature13 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature14 = table.Column<bool>(type: "bit", nullable: false),
                    FeatureName15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFeature15 = table.Column<bool>(type: "bit", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.CarFeatureId);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarId",
                table: "Reviews",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryID",
                table: "Cars",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryID",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RentPrice",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Services",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "CarStatuses",
                newName: "CarStatusName");

            migrationBuilder.RenameColumn(
                name: "km",
                table: "Cars",
                newName: "Km");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Cars",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Gear",
                table: "Cars",
                newName: "GearType");

            migrationBuilder.RenameColumn(
                name: "GasType",
                table: "Cars",
                newName: "CarModel");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Cars",
                newName: "CarCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CategoryID",
                table: "Cars",
                newName: "IX_Cars_CarCategoryID");

            migrationBuilder.RenameColumn(
                name: "CarDetailId",
                table: "CarDetails",
                newName: "CarDetailID");

            migrationBuilder.RenameColumn(
                name: "NameSurname",
                table: "AspNetUsers",
                newName: "Surname");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "CarDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CarDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    CarCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.CarCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_AppUserID",
                table: "CarDetails",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CarID",
                table: "Comments",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetails_AspNetUsers_AppUserID",
                table: "CarDetails",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarCategories_CarCategoryID",
                table: "Cars",
                column: "CarCategoryID",
                principalTable: "CarCategories",
                principalColumn: "CarCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
