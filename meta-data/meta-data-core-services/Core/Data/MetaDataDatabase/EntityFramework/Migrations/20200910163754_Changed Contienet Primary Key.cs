using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class ChangedContienetPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Continents",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Continents");

            migrationBuilder.AddColumn<string>(
                name: "ContinentCode",
                table: "Continents",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Continents",
                table: "Continents",
                column: "ContinentCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Continents",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "ContinentCode",
                table: "Continents");

            migrationBuilder.AddColumn<HierarchyId>(
                name: "ContinentId",
                table: "Continents",
                type: "hierarchyid",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Continents",
                table: "Continents",
                column: "ContinentId");
        }
    }
}
