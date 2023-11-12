using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Acess_Layer.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transports_CompanyID",
                table: "Transports",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_DriverID",
                table: "Transports",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_SquadID",
                table: "Transports",
                column: "SquadID");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_UserID",
                table: "Transports",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_VehicleID",
                table: "Transports",
                column: "VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Companies_CompanyID",
                table: "Transports",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Drivers_DriverID",
                table: "Transports",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "DriverID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Squads_SquadID",
                table: "Transports",
                column: "SquadID",
                principalTable: "Squads",
                principalColumn: "SquadID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Users_UserID",
                table: "Transports",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Vehicles_VehicleID",
                table: "Transports",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Companies_CompanyID",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Drivers_DriverID",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Squads_SquadID",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Users_UserID",
                table: "Transports");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Vehicles_VehicleID",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_CompanyID",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_DriverID",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_SquadID",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_UserID",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transports_VehicleID",
                table: "Transports");
        }
    }
}
