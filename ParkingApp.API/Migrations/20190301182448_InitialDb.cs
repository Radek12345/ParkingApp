using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.API.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    WeekdaysHourlyRate = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    WeekendHourlyRate = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(3, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingAreas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingAreas");
        }
    }
}
