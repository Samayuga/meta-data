using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingContinent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "PlanetId", "PlanetName" },
                values: new object[] { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/"), "Earth" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "PlanetId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/"));
        }
    }
}
