using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Acess_Layer.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VehicleStatus",
                table: "Vehicles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SquadStatus",
                table: "Squads",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DriverStatus",
                table: "Drivers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleStatus",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SquadStatus",
                table: "Squads");

            migrationBuilder.DropColumn(
                name: "DriverStatus",
                table: "Drivers");
        }
    }
}
