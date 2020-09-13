using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingAfricanCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryCode", "CallingCode", "Capital", "ContinentCode", "CountryName", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[,]
                {
                    { "BI", "+257", "Gitega", "AF", "Burundi", "BIF", "/wikimedia/countries/flags/bi.svg", "/wikimedia/countries/orthographic-maps/bi.svg" },
                    { "MU", null, "Port Louis", "AF", "Mauritius", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "MA", null, "Rabat", "AF", "Morocco", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "MZ", null, "Maputo", "AF", "Mozambique", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "NA", null, "Windhoek", "AF", "Namibia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "NE", null, "Niamey", "AF", "Niger", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "NG", null, "Abuja", "AF", "Nigeria", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "RW", null, "Kigali", "AF", "Rwanda", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ST", null, "São Tomé", "AF", "São Tomé and Príncipe", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SN", null, "Dakar", "AF", "Senegal", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SC", null, "Victoria", "AF", "Seychelles", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SL", null, "Freetown", "AF", "Sierra Leone", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SO", null, "Mogadishu", "AF", "Somalia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ZA", null, "Pretoria", "AF", "South Africa", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SS", null, "Juba", "AF", "South Sudan", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SD", null, "Khartoum", "AF", "Sudan", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "SZ", null, "Mbabane", "AF", "Swaziland", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "TZ", null, "Dodoma", "AF", "Tanzania", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "TG", null, "Lome", "AF", "Togo", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "TN", null, "Tunis", "AF", "Tunisia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "UG", null, "Kampala", "AF", "Uganda", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "EH", null, "El Aaiún", "AF", "Western Sahara", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "MR", null, "Nouakchott", "AF", "Mauritania", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ML", null, "Bamako", "AF", "Mali", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "MW", null, "Lilongwe", "AF", "Malawi", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "MG", null, "Antananarivo", "AF", "Madagascar", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "CM", "+237", "Yaoundé", "AF", "Cameroon", "XAF", "/wikimedia/countries/flags/cm.svg", "/wikimedia/countries/orthographic-maps/cm.svg" },
                    { "CV", null, "Praia", "AF", "Cape Verde", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "CF", null, "Bangui", "AF", "Central African Republic", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "TD", null, "N'Djamena", "AF", "Chad", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "KM", null, "Moroni", "AF", "Comoros", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "CG", null, "Brazzaville", "AF", "Republic of the Congo", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "CD", null, "Kinshasa", "AF", "Democratic Republic of the Congo", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "CI", null, "Yamoussoukro", "AF", "Ivory Coast", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "DJ", null, "Djibouti", "AF", "Djibouti", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "EG", null, "Cairo", "AF", "Egypt", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ZM", null, "Lusaka", "AF", "Zambia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "GQ", null, "Malabo", "AF", "Equatorial Guinea", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ET", null, "Addis Ababa", "AF", "Ethiopia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "GA", null, "Libreville", "AF", "Gabon", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "GM", null, "Banjul", "AF", "The Gambia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "GH", null, "Accra", "AF", "Ghana", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "GN", null, "Conakry", "AF", "Guinea", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "GW", null, "Bissau", "AF", "Guinea-Bissau", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "KE", null, "Nairobi", "AF", "Kenya", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "LS", null, "Maseru", "AF", "Lesotho", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "LR", null, "Monrovia", "AF", "Liberia", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "LY", null, "Tripoli", "AF", "Libya", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ER", null, "Asmara", "AF", "Eritrea", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" },
                    { "ZW", null, "Harare", "AF", "Zimbabwe", null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ER");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ET");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ML");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ST");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZW");

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    PlanetId = table.Column<HierarchyId>(type: "hierarchyid", nullable: false),
                    PlanetName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.PlanetId);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "PlanetId", "PlanetName" },
                values: new object[] { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/"), "Earth" });
        }
    }
}
