using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingMoreFieldsInCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CallingCode",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Flag",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISOCode",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrthographicMap",
                table: "Countries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CallingCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Flag",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ISOCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "OrthographicMap",
                table: "Countries");
        }
    }
}
