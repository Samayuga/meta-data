using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingFewCountryDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CD",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+243", "CDF", "/wikimedia/countries/flags/cd.svg", "/wikimedia/countries/orthographic-maps/cd.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CF",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+236", "XAF", " / wikimedia/countries/flags/cf.svg", "/wikimedia/countries/orthographic-maps/cf.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+242", "XAF", "/wikimedia/countries/flags/cg.svg", "/wikimedia/countries/orthographic-maps/cg.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CI",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+225", "XOF", "/wikimedia/countries/flags/ci.svg", "/wikimedia/countries/orthographic-maps/ci.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CV",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { " +238", "CVE", " / wikimedia/countries/flags/cv.svg", "/wikimedia/countries/orthographic-maps/cv.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DJ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+253", "DJF", "/wikimedia/countries/flags/dj.svg", "/wikimedia/countries/orthographic-maps/dj.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+20", "EGP", "/wikimedia/countries/flags/eg.svg", "/wikimedia/countries/orthographic-maps/eg.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EH",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+212", "MAD", "/wikimedia/countries/flags/eh.svg", "/wikimedia/countries/orthographic-maps/eh.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ER",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+291", "ERN", "/wikimedia/countries/flags/er.svg", "/wikimedia/countries/orthographic-maps/er.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ET",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+251", "ETB", "/wikimedia/countries/flags/et.svg", "/wikimedia/countries/orthographic-maps/et.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+241", "XAF", "/wikimedia/countries/flags/ga.svg", "/wikimedia/countries/orthographic-maps/ga.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GH",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+233", "GHS", "/wikimedia/countries/flags/gh.svg", "/wikimedia/countries/orthographic-maps/gh.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GM",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+220", "GMD", "/wikimedia/countries/flags/gm.svg", "/wikimedia/countries/orthographic-maps/gm.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GN",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+224", "GNF", "/wikimedia/countries/flags/gn.svg", "/wikimedia/countries/orthographic-maps/gn.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GQ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+240", "XAF", "/wikimedia/countries/flags/gq.svg", "/wikimedia/countries/orthographic-maps/gq.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GW",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+245", "XOF", "/wikimedia/countries/flags/gw.svg", "/wikimedia/countries/orthographic-maps/gw.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KE",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+254", "KES", "/wikimedia/countries/flags/ke.svg", "/wikimedia/countries/orthographic-maps/ke.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KM",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+269", "KMF", "/wikimedia/countries/flags/km.svg", "/wikimedia/countries/orthographic-maps/km.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LR",
                columns: new[] { "Flag", "OrthographicMap" },
                values: new object[] { "/wikimedia/countries/flags/lr.svg", "/wikimedia/countries/orthographic-maps/lr.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LS",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+266", "LSL", "/wikimedia/countries/flags/ls.svg", "/wikimedia/countries/orthographic-maps/ls.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LY",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+218", "LYD", "/wikimedia/countries/flags/ly.svg", "/wikimedia/countries/orthographic-maps/ly.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+212", "MAD", "/wikimedia/countries/flags/ma.svg", "/wikimedia/countries/orthographic-maps/ma.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+261", "MGA", "/wikimedia/countries/flags/mg.svg", "/wikimedia/countries/orthographic-maps/mg.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ML",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+223", "XOF", "/wikimedia/countries/flags/ml.svg", "/wikimedia/countries/orthographic-maps/ml.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MR",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+222", "MRU", "/wikimedia/countries/flags/mr.svg", "/wikimedia/countries/orthographic-maps/mr.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MU",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+230", "MUR", "/wikimedia/countries/flags/mu.svg", "/wikimedia/countries/orthographic-maps/mu.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MW",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+265", "MWK", "/wikimedia/countries/flags/mw.svg", "/wikimedia/countries/orthographic-maps/mw.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MZ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+258", "MZN", "/wikimedia/countries/flags/mz.svg", "/wikimedia/countries/orthographic-maps/mz.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+264", "NAD", "/wikimedia/countries/flags/na.svg", "/wikimedia/countries/orthographic-maps/na.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NE",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+227", "XOF", "/wikimedia/countries/flags/ne.svg", "/wikimedia/countries/orthographic-maps/ne.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+234", "NGN", "/wikimedia/countries/flags/ng.svg", "/wikimedia/countries/orthographic-maps/ng.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RW",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+250", "RWF", "/wikimedia/countries/flags/rw.svg", "/wikimedia/countries/orthographic-maps/rw.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SC",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+248", "SCR", "/wikimedia/countries/flags/sc.svg", "/wikimedia/countries/orthographic-maps/sc.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SD",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+249", "SDG", "/wikimedia/countries/flags/sd.svg", "/wikimedia/countries/orthographic-maps/sd.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SL",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+232", "SLL", "/wikimedia/countries/flags/sl.svg", "/wikimedia/countries/orthographic-maps/sl.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SN",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+221", "XOF", "/wikimedia/countries/flags/sn.svg", "/wikimedia/countries/orthographic-maps/sn.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SO",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+252", "SOS", "/wikimedia/countries/flags/so.svg", "/wikimedia/countries/orthographic-maps/so.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SS",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+211", "SSP", "/wikimedia/countries/flags/ss.svg", "/wikimedia/countries/orthographic-maps/ss.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ST",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+239", "STN", "/wikimedia/countries/flags/st.svg", "/wikimedia/countries/orthographic-maps/st.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SZ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+268", "ZAR", "/wikimedia/countries/flags/sz.svg", "/wikimedia/countries/orthographic-maps/sz.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TD",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+235", "XAF", " / wikimedia/countries/flags/td.svg", "/wikimedia/countries/orthographic-maps/td.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+228", "XOF", "/wikimedia/countries/flags/tg.svg", "/wikimedia/countries/orthographic-maps/tg.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TN",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+216", "TND", "/wikimedia/countries/flags/tn.svg", "/wikimedia/countries/orthographic-maps/tn.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TZ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+255", "TZS", "/wikimedia/countries/flags/tz.svg", "/wikimedia/countries/orthographic-maps/tz.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+256", "UGX", "/wikimedia/countries/flags/ug.svg", "/wikimedia/countries/orthographic-maps/ug.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+27", "ZAR", "/wikimedia/countries/flags/za.svg", "/wikimedia/countries/orthographic-maps/za.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZM",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { "+260", "ZMW", "/wikimedia/countries/flags/zm.svg", "/wikimedia/countries/orthographic-maps/zm.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZW",
                columns: new[] { "CallingCode", "Flag", "OrthographicMap" },
                values: new object[] { "+263", "/wikimedia/countries/flags/zw.svg", "/wikimedia/countries/orthographic-maps/zw.svg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CD",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CF",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CI",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CV",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DJ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EH",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ER",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ET",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GH",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GM",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GN",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GQ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GW",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KE",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KM",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LR",
                columns: new[] { "Flag", "OrthographicMap" },
                values: new object[] { "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LS",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LY",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ML",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MR",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MU",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MW",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MZ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NE",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RW",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SC",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SD",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SL",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SN",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SO",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SS",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ST",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SZ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TD",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TN",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TZ",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UG",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZA",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZM",
                columns: new[] { "CallingCode", "CurrencyCode", "Flag", "OrthographicMap" },
                values: new object[] { null, null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ZW",
                columns: new[] { "CallingCode", "Flag", "OrthographicMap" },
                values: new object[] { null, "/wikimedia/countries/flags/.svg", "/wikimedia/countries/orthographic-maps/.svg" });
        }
    }
}
