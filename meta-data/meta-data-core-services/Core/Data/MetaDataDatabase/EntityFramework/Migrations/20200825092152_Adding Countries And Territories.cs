using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingCountriesAndTerritories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/1/"), "Algeria" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/11/"), "Cayman Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/12/"), "Clipperton Island" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/13/"), "Costa Rica" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/14/"), "Cuba" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/15/"), "Curaçao" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/16/"), "Dominica" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/17/"), "Dominican Republic" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/18/"), "El Salvador" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/10/"), "Canada" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/19/"), "Greenland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/21/"), "Guadeloupe" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/22/"), "Guatemala" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/23/"), "Haiti" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/24/"), "Honduras" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/25/"), "Jamaica" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/26/"), "Martinique" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/27/"), "Mexico" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/28/"), "Montserrat" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/20/"), "Grenada" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/29/"), "Navassa Island" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/9/"), "British Virgin Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/7/"), "Bermuda" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/35/"), "Romania" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/36/"), "Moscow" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/37/"), "San Marino" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/38/"), "Serbia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/39/"), "Slovakia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/40/"), "Slovenia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/41/"), "Spain" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/42/"), "Sweden" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/8/"), "Bonaire" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/43/"), "Switzerland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/45/"), "United Kingdom" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/46/"), "Vatican City" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/1/"), "Antigua and Barbuda" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/2/"), "Anguilla" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/3/"), "Aruba" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/4/"), "The Bahamas" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/5/"), "Barbados" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/6/"), "Belize" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/44/"), "Ukraine" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/34/"), "Portugal" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/30/"), "Nicaragua" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/32/"), "Puerto Rico" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/10/"), "Paraguay" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/11/"), "Peru" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/12/"), "South Georgia and the South Sandwich Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/13/"), "Suriname" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/14/"), "Uruguay" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/15/"), "Venezuela" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/1/"), "Australia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/2/"), "Federated States of Micronesia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/9/"), "Guyana" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/3/"), "Fiji" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/5/"), "Marshall Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/6/"), "Nauru" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/7/"), "New Zealand" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/8/"), "Palau" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/9/"), "Papua New Guinea" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/10/"), "Samoa" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/11/"), "Solomon Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/12/"), "Tonga" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/4/"), "Kiribati" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/31/"), "Panama" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/8/"), "French Guiana" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/6/"), "Ecuador" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/33/"), "Saba" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/34/"), "Saint Barthelemy" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/35/"), "Saint Kitts and Nevis" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/36/"), "Saint Lucia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/37/"), "Saint Martin" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/38/"), "Saint Pierre and Miquelon" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/39/"), "Saint Vincent and the Grenadines" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/40/"), "Sint Eustatius" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/7/"), "Falkland Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/41/"), "Sint Maarten" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/43/"), "Turks and Caicos" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/44/"), "United States of America" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/45/"), "US Virgin Islands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/1/"), "Argentina" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/2/"), "Bolivia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/3/"), "Brazil" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/4/"), "Chile" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/5/"), "Colombia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/42/"), "Trinidad and Tobago" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/13/"), "Tuvalu" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/33/"), "Poland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/31/"), "Netherlands" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/24/"), "Guinea-Bissau" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/25/"), "Kenya" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/26/"), "Lesotho" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/27/"), "Liberia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/28/"), "Libya" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/29/"), "Madagascar" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/30/"), "Malawi" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/31/"), "Mali" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/23/"), "Guinea" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/32/"), "Mauritania" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/34/"), "Morocco" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/35/"), "Mozambique" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/36/"), "Namibia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/37/"), "Niger" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/38/"), "Nigeria" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/39/"), "Rwanda" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/40/"), "São Tomé and Príncipe" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/41/"), "Senegal" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/33/"), "Mauritius" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/42/"), "Seychelles" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/22/"), "Ghana" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/20/"), "Gabon" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/2/"), "Angola" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/3/"), "Benin" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/4/"), "Botswana" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/5/"), "Burkina Faso" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/6/"), "Burundi" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/7/"), "Cameroon" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/8/"), "Cape Verde" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/9/"), "Central African Republic" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/21/"), "The Gambia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/10/"), "Chad" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/12/"), "Republic of the Congo" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/13/"), "Democratic Republic of the Congo" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/14/"), "Ivory Coast" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/15/"), "Djibouti" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/16/"), "Egypt" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/17/"), "Equatorial Guinea" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/18/"), "Eritrea" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/19/"), "Ethiopia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/11/"), "Comoros" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/32/"), "Norway" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/43/"), "Sierra Leone" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/45/"), "South Africa" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/13/"), "Finland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/14/"), "France" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/15/"), "Germany" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/16/"), "Greece" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/17/"), "Hungary" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/18/"), "Iceland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/19/"), "Republic of Ireland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/20/"), "Italy" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/12/"), "Estonia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/21/"), "Kosovo" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/23/"), "Liechtenstein" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/24/"), "Lithuania" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/25/"), "Luxembourg" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/26/"), "North Macedonia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/27/"), "Malta" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/28/"), "Moldova" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/29/"), "Monaco" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/30/"), "Montenegro" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/22/"), "Latvia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/44/"), "Somalia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/11/"), "Denmark" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/9/"), "Cyprus" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/46/"), "South Sudan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/47/"), "Sudan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/48/"), "Swaziland" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/49/"), "Tanzania" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/50/"), "Togo" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/51/"), "Tunisia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/52/"), "Uganda" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/53/"), "Western Sahara" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/10/"), "Czech Republic" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/54/"), "Zambia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/1/"), "Albania" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/2/"), "Andorra" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/3/"), "Austria" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/4/"), "Belarus" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/5/"), "Belgium" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/6/"), "Bosnia and Herzegovina" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/7/"), "Bulgaria" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/8/"), "Croatia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/55/"), "Zimbabwe" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/14/"), "Vanuatu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/1/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/2/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/3/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/4/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/5/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/6/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/7/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/8/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/9/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/10/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/11/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/12/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/13/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/14/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/15/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/16/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/17/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/18/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/19/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/20/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/21/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/22/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/23/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/24/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/25/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/26/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/27/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/28/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/29/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/30/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/31/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/32/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/33/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/34/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/35/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/36/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/37/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/38/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/39/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/40/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/41/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/42/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/43/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/44/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/45/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/46/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/47/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/48/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/49/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/50/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/51/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/52/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/53/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/54/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/55/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/1/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/2/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/3/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/4/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/5/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/6/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/7/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/8/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/9/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/10/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/11/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/12/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/13/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/14/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/15/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/16/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/17/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/18/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/19/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/20/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/21/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/22/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/23/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/24/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/25/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/26/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/27/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/28/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/29/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/30/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/31/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/32/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/33/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/34/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/35/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/36/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/37/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/38/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/39/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/40/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/41/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/42/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/43/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/44/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/45/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/46/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/1/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/2/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/3/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/4/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/5/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/6/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/7/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/8/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/9/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/10/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/11/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/12/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/13/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/14/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/15/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/16/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/17/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/18/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/19/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/20/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/21/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/22/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/23/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/24/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/25/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/26/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/27/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/28/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/29/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/30/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/31/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/32/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/33/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/34/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/35/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/36/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/37/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/38/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/39/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/40/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/41/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/42/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/43/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/44/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/45/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/1/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/2/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/3/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/4/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/5/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/6/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/7/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/8/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/9/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/10/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/11/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/12/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/13/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/14/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/15/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/1/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/2/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/3/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/4/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/5/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/6/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/7/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/8/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/9/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/10/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/11/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/12/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/13/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/14/"));
        }
    }
}
