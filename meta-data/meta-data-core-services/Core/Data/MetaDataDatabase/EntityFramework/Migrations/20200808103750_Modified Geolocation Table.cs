using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class ModifiedGeolocationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<HierarchyId>(
                name: "GeolocationTypeId",
                table: "Geolocations",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Geolocations_GeolocationTypeId",
                table: "Geolocations",
                column: "GeolocationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Geolocations_GeolocationTypes_GeolocationTypeId",
                table: "Geolocations",
                column: "GeolocationTypeId",
                principalTable: "GeolocationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Geolocations_GeolocationTypes_GeolocationTypeId",
                table: "Geolocations");

            migrationBuilder.DropIndex(
                name: "IX_Geolocations_GeolocationTypeId",
                table: "Geolocations");

            migrationBuilder.DropColumn(
                name: "GeolocationTypeId",
                table: "Geolocations");
        }
    }
}
