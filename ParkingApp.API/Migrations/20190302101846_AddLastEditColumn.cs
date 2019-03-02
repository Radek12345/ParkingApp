using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.API.Migrations
{
    public partial class AddLastEditColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastEdit",
                table: "ParkingAreas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastEdit",
                table: "ParkingAreas");
        }
    }
}
