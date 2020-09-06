using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class CorrectedBaseNumberInCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BHD",
                column: "BaseNumber",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "IQD",
                column: "BaseNumber",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KWD",
                column: "BaseNumber",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LYD",
                column: "BaseNumber",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MGA",
                column: "BaseNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MRU",
                column: "BaseNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "OMR",
                column: "BaseNumber",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TND",
                column: "BaseNumber",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "VND",
                column: "BaseNumber",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BHD",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "IQD",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KWD",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LYD",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MGA",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MRU",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "OMR",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TND",
                column: "BaseNumber",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "VND",
                column: "BaseNumber",
                value: 100);
        }
    }
}
