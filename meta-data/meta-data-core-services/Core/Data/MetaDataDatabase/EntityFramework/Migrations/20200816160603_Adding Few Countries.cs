using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingFewCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/1/"), "Afghanistan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/27/"), "Myanmar" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/28/"), "Nepal" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/29/"), "North Korea" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/30/"), "Oman" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/31/"), "Pakistan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/32/"), "Philippines" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/33/"), "Palestine" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/34/"), "Qatar" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/35/"), "Russia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/36/"), "Saudi Arabia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/37/"), "Singapore" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/38/"), "South Korea" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/39/"), "Sri Lanka" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/40/"), "Syria" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/41/"), "Tajikistan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/42/"), "Thailand" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/43/"), "Turkey" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/44/"), "Turkmenistan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/45/"), "Taiwan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/46/"), "United Arab Emirates" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/47/"), "Uzbekistan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/26/"), "Mongolia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/48/"), "Vietnam" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/25/"), "Maldives" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/23/"), "Lebanon" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/2/"), "Armenia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/3/"), "Azerbaijan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/4/"), "Bahrain" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/5/"), "Bangladesh" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/6/"), "Bhutan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/7/"), "Brunei" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/8/"), "Cambodia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/9/"), "China" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/10/"), "East Timor" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/11/"), "Georgia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/12/"), "India" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/13/"), "Indonesia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/14/"), "Iran" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/15/"), "Iraq" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/16/"), "Israel" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/17/"), "Japan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/18/"), "Jordan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/19/"), "Kazakhstan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/20/"), "Kuwait" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/21/"), "Kyrgyzstan" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/22/"), "Laos" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/24/"), "Malaysia" },
                    { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/49/"), "Yemen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/1/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/2/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/3/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/4/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/5/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/6/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/7/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/8/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/9/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/10/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/11/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/12/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/13/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/14/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/15/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/16/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/17/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/18/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/19/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/20/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/21/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/22/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/23/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/24/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/25/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/26/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/27/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/28/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/29/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/30/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/31/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/32/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/33/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/34/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/35/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/36/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/37/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/38/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/39/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/40/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/41/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/42/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/43/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/44/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/45/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/46/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/47/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/48/"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/49/"));
        }
    }
}
