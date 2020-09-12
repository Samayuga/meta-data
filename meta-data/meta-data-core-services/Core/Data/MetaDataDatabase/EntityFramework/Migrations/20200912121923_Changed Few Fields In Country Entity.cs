using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class ChangedFewFieldsInCountryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyISOCode",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencyISOCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CurrencyISOCode",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode",
                table: "Countries",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryCode", "CallingCode", "Capital", "ContinentCode", "CountryName", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "DZ", "+213", "Algiers", "AF", "Algeria", "DZD", "/wikimedia/countries/flags/dz.svg", "/wikimedia/countries/orthographic-maps/dz.svg" });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyCode",
                table: "Countries",
                column: "CurrencyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyCode",
                table: "Countries",
                column: "CurrencyCode",
                principalTable: "Currencies",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyCode",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencyCode",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DZ");

            migrationBuilder.DropColumn(
                name: "CurrencyCode",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyISOCode",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyISOCode",
                table: "Countries",
                column: "CurrencyISOCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyISOCode",
                table: "Countries",
                column: "CurrencyISOCode",
                principalTable: "Currencies",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
