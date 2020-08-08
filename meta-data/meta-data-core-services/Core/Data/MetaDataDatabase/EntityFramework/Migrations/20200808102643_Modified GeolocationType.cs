using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class ModifiedGeolocationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeolocationTypes",
                table: "GeolocationTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GeolocationTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<HierarchyId>(
                name: "Id",
                table: "GeolocationTypes",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeolocationTypes",
                table: "GeolocationTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeolocationTypes",
                table: "GeolocationTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GeolocationTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GeolocationTypes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeolocationTypes",
                table: "GeolocationTypes",
                column: "Name");
        }
    }
}
