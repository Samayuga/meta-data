using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class RemovingContinentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/2/"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentId", "ContinentName" },
                values: new object[,]
                {
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/"), "Africa" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/2/"), "Antarctica" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/"), "Asia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/"), "Europe" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/"), "North America" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/"), "South America" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/"), "Australia" }
                });
        }
    }
}
