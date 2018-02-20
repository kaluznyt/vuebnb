using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vuebnb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    About = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AmenityBreakfast = table.Column<bool>(nullable: false),
                    AmenityKitchen = table.Column<bool>(nullable: false),
                    AmenityLaptop = table.Column<bool>(nullable: false),
                    AmenityPetsAllowed = table.Column<bool>(nullable: false),
                    AmenityTv = table.Column<bool>(nullable: false),
                    AmenityWifi = table.Column<bool>(nullable: false),
                    PriceExtraPeople = table.Column<string>(nullable: true),
                    PriceMonthlyDiscount = table.Column<string>(nullable: true),
                    PricePerNight = table.Column<string>(nullable: true),
                    PriceWeeklyDiscount = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listings");
        }
    }
}
