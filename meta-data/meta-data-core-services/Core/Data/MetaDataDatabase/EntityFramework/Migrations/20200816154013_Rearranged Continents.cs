using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class RearrangedContinents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/"),
                column: "ContinentName",
                value: "South America");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/"),
                column: "ContinentName",
                value: "Australia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/"),
                column: "ContinentName",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/"),
                column: "ContinentName",
                value: "South America");
        }
    }
}
