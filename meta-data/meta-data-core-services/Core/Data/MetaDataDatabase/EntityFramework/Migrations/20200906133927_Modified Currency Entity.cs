using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class ModifiedCurrencyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "ISOCode",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyISOCode",
                table: "Currencies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyISOCode",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "CurrencyISOCode");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyISOCode",
                table: "Countries",
                column: "CurrencyISOCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyISOCode",
                table: "Countries",
                column: "CurrencyISOCode",
                principalTable: "Currencies",
                principalColumn: "CurrencyISOCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyISOCode",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencyISOCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CurrencyISOCode",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "CurrencyISOCode",
                table: "Countries");

            migrationBuilder.AddColumn<HierarchyId>(
                name: "CurrencyId",
                table: "Currencies",
                type: "hierarchyid",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "ISOCode",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<HierarchyId>(
                name: "CurrencyId",
                table: "Countries",
                type: "hierarchyid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
