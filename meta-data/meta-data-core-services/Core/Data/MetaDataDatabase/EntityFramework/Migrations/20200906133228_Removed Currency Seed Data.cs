using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class RemovedCurrencySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "BaseNumber", "FractionalUnit", "ISOCode", "Name", "Symbol" },
                values: new object[] { Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/"), 100, "Kopek", "RUB", "Russian ruble", "₽" });
        }
    }
}
