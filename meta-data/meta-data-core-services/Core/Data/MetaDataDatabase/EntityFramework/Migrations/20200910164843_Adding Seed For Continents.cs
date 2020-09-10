using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingSeedForContinents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentCode", "ContinentName" },
                values: new object[,]
                {
                    { "AF", "Africa" },
                    { "AN", "Antarctica" },
                    { "AS", "Asia" },
                    { "EU", "Europe" },
                    { "NA", "North America" },
                    { "OC", "Oceania" },
                    { "SA", "South America" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "AF");

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "AN");

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "AS");

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "EU");

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "NA");

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "OC");

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentCode",
                keyValue: "SA");
        }
    }
}
