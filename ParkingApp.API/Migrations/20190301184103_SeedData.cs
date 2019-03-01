using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO ParkingAreas 
                (name, WeekdaysHourlyRate, WeekendHourlyRate) 
                VALUES ('TestArea1', 4, 3)");

            migrationBuilder.Sql(@"INSERT INTO ParkingAreas 
                (name, WeekdaysHourlyRate, WeekendHourlyRate) 
                VALUES ('TestArea2', 4.50, 3.60)");

            migrationBuilder.Sql(@"INSERT INTO ParkingAreas 
                (name, WeekdaysHourlyRate, WeekendHourlyRate, Discount) 
                VALUES ('TestArea3', 4.50, 3.60, 0.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ParkingAreas WHERE name LIKE 'TestArea%'");
        }
    }
}
