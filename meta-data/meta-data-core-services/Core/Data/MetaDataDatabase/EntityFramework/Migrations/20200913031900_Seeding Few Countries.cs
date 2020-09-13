using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class SeedingFewCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryCode", "CallingCode", "Capital", "ContinentCode", "CountryName", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[,]
                {
                    { "AO", "+244", "Luanda", "AF", "Angola", "AOA", "/wikimedia/countries/flags/ao.svg", "/wikimedia/countries/orthographic-maps/ao.svg" },
                    { "BJ", "+229", "Porto-Novo", "AF", "Benin", "XOF", "/wikimedia/countries/flags/bj.svg", "/wikimedia/countries/orthographic-maps/bj.svg" },
                    { "BW", "+267", "Gaborone", "AF", "Botswana", "BWP", "/wikimedia/countries/flags/bw.svg", "/wikimedia/countries/orthographic-maps/bw.svg" },
                    { "BF", "+226", "Ouagadougou", "AF", "Burkina Faso", "XOF", "/wikimedia/countries/flags/bf.svg", "/wikimedia/countries/orthographic-maps/bf.svg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BW");
        }
    }
}
