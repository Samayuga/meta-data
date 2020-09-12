using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class AddingCountriesAfterChangineKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryISOCode",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Countries",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryCode");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryCode", "CallingCode", "Capital", "CountryName", "CurrencyISOCode", "Flag", "ISOCode", "OrthographicMap" },
                values: new object[,]
                {
                    { "A1", null, null, "Anonymous Proxy", null, null, null, null },
                    { "MX", null, null, "Mexico", null, null, null, null },
                    { "MY", null, null, "Malaysia", null, null, null, null },
                    { "MZ", null, null, "Mozambique", null, null, null, null },
                    { "NA", null, null, "Namibia", null, null, null, null },
                    { "NC", null, null, "New Caledonia", null, null, null, null },
                    { "NE", null, null, "Niger", null, null, null, null },
                    { "NF", null, null, "Norfolk Island", null, null, null, null },
                    { "NG", null, null, "Nigeria", null, null, null, null },
                    { "NI", null, null, "Nicaragua", null, null, null, null },
                    { "NL", null, null, "Netherlands", null, null, null, null },
                    { "NO", null, null, "Norway", null, null, null, null },
                    { "NP", null, null, "Nepal", null, null, null, null },
                    { "NR", null, null, "Nauru", null, null, null, null },
                    { "NU", null, null, "Niue", null, null, null, null },
                    { "NZ", null, null, "New Zealand", null, null, null, null },
                    { "OM", null, null, "Oman", null, null, null, null },
                    { "PA", null, null, "Panama", null, null, null, null },
                    { "PE", null, null, "Peru", null, null, null, null },
                    { "PF", null, null, "French Polynesia", null, null, null, null },
                    { "PG", null, null, "Papua New Guinea", null, null, null, null },
                    { "PH", null, null, "Philippines", null, null, null, null },
                    { "PK", null, null, "Pakistan", null, null, null, null },
                    { "PL", null, null, "Poland", null, null, null, null },
                    { "PM", null, null, "Saint Pierre and Miquelon", null, null, null, null },
                    { "PN", null, null, "Pitcairn", null, null, null, null },
                    { "PR", null, null, "Puerto Rico", null, null, null, null },
                    { "PS", null, null, "Palestinian Territory", null, null, null, null },
                    { "MW", null, null, "Malawi", null, null, null, null },
                    { "MV", null, null, "Maldives", null, null, null, null },
                    { "MU", null, null, "Mauritius", null, null, null, null },
                    { "MT", null, null, "Malta", null, null, null, null },
                    { "KZ", null, null, "Kazakhstan", null, null, null, null },
                    { "LA", null, null, "Lao People's Democratic Republic", null, null, null, null },
                    { "LB", null, null, "Lebanon", null, null, null, null },
                    { "LC", null, null, "Saint Lucia", null, null, null, null },
                    { "LI", null, null, "Liechtenstein", null, null, null, null },
                    { "LK", null, null, "Sri Lanka", null, null, null, null },
                    { "LR", null, null, "Liberia", null, null, null, null },
                    { "LS", null, null, "Lesotho", null, null, null, null },
                    { "LT", null, null, "Lithuania", null, null, null, null },
                    { "LU", null, null, "Luxembourg", null, null, null, null },
                    { "LV", null, null, "Latvia", null, null, null, null },
                    { "LY", null, null, "Libyan Arab Jamahiriya", null, null, null, null },
                    { "MA", null, null, "Morocco", null, null, null, null },
                    { "PT", null, null, "Portugal", null, null, null, null },
                    { "MC", null, null, "Monaco", null, null, null, null },
                    { "ME", null, null, "Montenegro", null, null, null, null },
                    { "MF", null, null, "Saint Martin", null, null, null, null },
                    { "MG", null, null, "Madagascar", null, null, null, null },
                    { "MH", null, null, "Marshall Islands", null, null, null, null },
                    { "MK", null, null, "Macedonia", null, null, null, null },
                    { "ML", null, null, "Mali", null, null, null, null },
                    { "MM", null, null, "Myanmar", null, null, null, null },
                    { "MN", null, null, "Mongolia", null, null, null, null },
                    { "MO", null, null, "Macao", null, null, null, null },
                    { "MP", null, null, "Northern Mariana Islands", null, null, null, null },
                    { "MQ", null, null, "Martinique", null, null, null, null },
                    { "MR", null, null, "Mauritania", null, null, null, null },
                    { "MS", null, null, "Montserrat", null, null, null, null },
                    { "MD", null, null, "Moldova, Republic of", null, null, null, null },
                    { "PW", null, null, "Palau", null, null, null, null },
                    { "PY", null, null, "Paraguay", null, null, null, null },
                    { "QA", null, null, "Qatar", null, null, null, null },
                    { "TK", null, null, "Tokelau", null, null, null, null },
                    { "TL", null, null, "Timor-Leste", null, null, null, null },
                    { "TM", null, null, "Turkmenistan", null, null, null, null },
                    { "TN", null, null, "Tunisia", null, null, null, null },
                    { "TO", null, null, "Tonga", null, null, null, null },
                    { "TR", null, null, "Turkey", null, null, null, null },
                    { "TT", null, null, "Trinidad and Tobago", null, null, null, null },
                    { "TV", null, null, "Tuvalu", null, null, null, null },
                    { "TW", null, null, "Taiwan", null, null, null, null },
                    { "TZ", null, null, "Tanzania, United Republic of", null, null, null, null },
                    { "UA", null, null, "Ukraine", null, null, null, null },
                    { "UG", null, null, "Uganda", null, null, null, null },
                    { "UM", null, null, "United States Minor Outlying Islands", null, null, null, null },
                    { "TJ", null, null, "Tajikistan", null, null, null, null },
                    { "US", null, null, "United States", null, null, null, null },
                    { "UZ", null, null, "Uzbekistan", null, null, null, null },
                    { "VA", null, null, "Holy See (Vatican City State)", null, null, null, null },
                    { "VC", null, null, "Saint Vincent and the Grenadines", null, null, null, null },
                    { "VE", null, null, "Venezuela", null, null, null, null },
                    { "VG", null, null, "Virgin Islands, British", null, null, null, null },
                    { "VI", null, null, "Virgin Islands, U.S.", null, null, null, null },
                    { "VN", null, null, "Vietnam", null, null, null, null },
                    { "VU", null, null, "Vanuatu", null, null, null, null },
                    { "WF", null, null, "Wallis and Futuna", null, null, null, null },
                    { "WS", null, null, "Samoa", null, null, null, null },
                    { "YE", null, null, "Yemen", null, null, null, null },
                    { "YT", null, null, "Mayotte", null, null, null, null },
                    { "ZA", null, null, "South Africa", null, null, null, null },
                    { "UY", null, null, "Uruguay", null, null, null, null },
                    { "KY", null, null, "Cayman Islands", null, null, null, null },
                    { "TH", null, null, "Thailand", null, null, null, null },
                    { "TF", null, null, "French Southern Territories", null, null, null, null },
                    { "RE", null, null, "Reunion", null, null, null, null },
                    { "RO", null, null, "Romania", null, null, null, null },
                    { "RS", null, null, "Serbia", null, null, null, null },
                    { "RU", null, null, "Russian Federation", null, null, null, null },
                    { "RW", null, null, "Rwanda", null, null, null, null },
                    { "SA", null, null, "Saudi Arabia", null, null, null, null },
                    { "SB", null, null, "Solomon Islands", null, null, null, null },
                    { "SC", null, null, "Seychelles", null, null, null, null },
                    { "SD", null, null, "Sudan", null, null, null, null },
                    { "SE", null, null, "Sweden", null, null, null, null },
                    { "SG", null, null, "Singapore", null, null, null, null },
                    { "SH", null, null, "Saint Helena", null, null, null, null },
                    { "SI", null, null, "Slovenia", null, null, null, null },
                    { "TG", null, null, "Togo", null, null, null, null },
                    { "SJ", null, null, "Svalbard and Jan Mayen", null, null, null, null },
                    { "SL", null, null, "Sierra Leone", null, null, null, null },
                    { "SM", null, null, "San Marino", null, null, null, null },
                    { "SN", null, null, "Senegal", null, null, null, null },
                    { "SO", null, null, "Somalia", null, null, null, null },
                    { "SR", null, null, "Suriname", null, null, null, null },
                    { "SS", null, null, "South Sudan", null, null, null, null },
                    { "ST", null, null, "Sao Tome and Principe", null, null, null, null },
                    { "SV", null, null, "El Salvador", null, null, null, null },
                    { "SX", null, null, "Sint Maarten", null, null, null, null },
                    { "SY", null, null, "Syrian Arab Republic", null, null, null, null },
                    { "SZ", null, null, "Swaziland", null, null, null, null },
                    { "TC", null, null, "Turks and Caicos Islands", null, null, null, null },
                    { "TD", null, null, "Chad", null, null, null, null },
                    { "SK", null, null, "Slovakia", null, null, null, null },
                    { "KW", null, null, "Kuwait", null, null, null, null },
                    { "KR", null, null, "Korea, Republic of", null, null, null, null },
                    { "KP", null, null, "Korea, Democratic People's Republic of", null, null, null, null },
                    { "BQ", null, null, "Bonaire, Saint Eustatius and Saba", null, null, null, null },
                    { "BR", null, null, "Brazil", null, null, null, null },
                    { "BS", null, null, "Bahamas", null, null, null, null },
                    { "BT", null, null, "Bhutan", null, null, null, null },
                    { "BV", null, null, "Bouvet Island", null, null, null, null },
                    { "BW", null, null, "Botswana", null, null, null, null },
                    { "BY", null, null, "Belarus", null, null, null, null },
                    { "BZ", null, null, "Belize", null, null, null, null },
                    { "CA", null, null, "Canada", null, null, null, null },
                    { "CC", null, null, "Cocos (Keeling) Islands", null, null, null, null },
                    { "CD", null, null, "Congo, The Democratic Republic of the", null, null, null, null },
                    { "CF", null, null, "Central African Republic", null, null, null, null },
                    { "CG", null, null, "Congo", null, null, null, null },
                    { "BO", null, null, "Bolivia", null, null, null, null },
                    { "CH", null, null, "Switzerland", null, null, null, null },
                    { "CK", null, null, "Cook Islands", null, null, null, null },
                    { "CL", null, null, "Chile", null, null, null, null },
                    { "CM", null, null, "Cameroon", null, null, null, null },
                    { "CN", null, null, "China", null, null, null, null },
                    { "CO", null, null, "Colombia", null, null, null, null },
                    { "CR", null, null, "Costa Rica", null, null, null, null },
                    { "CU", null, null, "Cuba", null, null, null, null },
                    { "CV", null, null, "Cape Verde", null, null, null, null },
                    { "CW", null, null, "Curacao", null, null, null, null },
                    { "CX", null, null, "Christmas Island", null, null, null, null },
                    { "CY", null, null, "Cyprus", null, null, null, null },
                    { "CZ", null, null, "Czech Republic", null, null, null, null },
                    { "DE", null, null, "Germany", null, null, null, null },
                    { "CI", null, null, "Cote d'Ivoire", null, null, null, null },
                    { "DJ", null, null, "Djibouti", null, null, null, null },
                    { "BN", null, null, "Brunei Darussalam", null, null, null, null },
                    { "BL", null, null, "Saint Barthelemy", null, null, null, null },
                    { "A2", null, null, "Satellite Provider", null, null, null, null },
                    { "O1", null, null, "Other Country", null, null, null, null },
                    { "AD", null, null, "Andorra", null, null, null, null },
                    { "AE", null, null, "United Arab Emirates", null, null, null, null },
                    { "AF", null, null, "Afghanistan", null, null, null, null },
                    { "AG", null, null, "Antigua and Barbuda", null, null, null, null },
                    { "AI", null, null, "Anguilla", null, null, null, null },
                    { "AL", null, null, "Albania", null, null, null, null },
                    { "AM", null, null, "Armenia", null, null, null, null },
                    { "AO", null, null, "Angola", null, null, null, null },
                    { "AP", null, null, "Asia/Pacific Region", null, null, null, null },
                    { "AQ", null, null, "Antarctica", null, null, null, null },
                    { "AR", null, null, "Argentina", null, null, null, null },
                    { "BM", null, null, "Bermuda", null, null, null, null },
                    { "AS", null, null, "American Samoa", null, null, null, null },
                    { "AU", null, null, "Australia", null, null, null, null },
                    { "AW", null, null, "Aruba", null, null, null, null },
                    { "AX", null, null, "Aland Islands", null, null, null, null },
                    { "AZ", null, null, "Azerbaijan", null, null, null, null },
                    { "BA", null, null, "Bosnia and Herzegovina", null, null, null, null },
                    { "BB", null, null, "Barbados", null, null, null, null },
                    { "BD", null, null, "Bangladesh", null, null, null, null },
                    { "BE", null, null, "Belgium", null, null, null, null },
                    { "BF", null, null, "Burkina Faso", null, null, null, null },
                    { "BG", null, null, "Bulgaria", null, null, null, null },
                    { "BH", null, null, "Bahrain", null, null, null, null },
                    { "BI", null, null, "Burundi", null, null, null, null },
                    { "BJ", null, null, "Benin", null, null, null, null },
                    { "AT", null, null, "Austria", null, null, null, null },
                    { "ZM", null, null, "Zambia", null, null, null, null },
                    { "DK", null, null, "Denmark", null, null, null, null },
                    { "DO", null, null, "Dominican Republic", null, null, null, null },
                    { "GW", null, null, "Guinea-Bissau", null, null, null, null },
                    { "GY", null, null, "Guyana", null, null, null, null },
                    { "HK", null, null, "Hong Kong", null, null, null, null },
                    { "HM", null, null, "Heard Island and McDonald Islands", null, null, null, null },
                    { "HN", null, null, "Honduras", null, null, null, null },
                    { "HR", null, null, "Croatia", null, null, null, null },
                    { "HT", null, null, "Haiti", null, null, null, null },
                    { "HU", null, null, "Hungary", null, null, null, null },
                    { "ID", null, null, "Indonesia", null, null, null, null },
                    { "IE", null, null, "Ireland", null, null, null, null },
                    { "IL", null, null, "Israel", null, null, null, null },
                    { "IM", null, null, "Isle of Man", null, null, null, null },
                    { "IN", null, null, "India", null, null, null, null },
                    { "GU", null, null, "Guam", null, null, null, null },
                    { "IO", null, null, "British Indian Ocean Territory", null, null, null, null },
                    { "IR", null, null, "Iran, Islamic Republic of", null, null, null, null },
                    { "IS", null, null, "Iceland", null, null, null, null },
                    { "IT", null, null, "Italy", null, null, null, null },
                    { "JE", null, null, "Jersey", null, null, null, null },
                    { "JM", null, null, "Jamaica", null, null, null, null },
                    { "JO", null, null, "Jordan", null, null, null, null },
                    { "JP", null, null, "Japan", null, null, null, null },
                    { "KE", null, null, "Kenya", null, null, null, null },
                    { "KG", null, null, "Kyrgyzstan", null, null, null, null },
                    { "KH", null, null, "Cambodia", null, null, null, null },
                    { "KI", null, null, "Kiribati", null, null, null, null },
                    { "KM", null, null, "Comoros", null, null, null, null },
                    { "KN", null, null, "Saint Kitts and Nevis", null, null, null, null },
                    { "IQ", null, null, "Iraq", null, null, null, null },
                    { "DM", null, null, "Dominica", null, null, null, null },
                    { "GT", null, null, "Guatemala", null, null, null, null },
                    { "GR", null, null, "Greece", null, null, null, null },
                    { "DZ", null, null, "Algeria", null, null, null, null },
                    { "EC", null, null, "Ecuador", null, null, null, null },
                    { "EE", null, null, "Estonia", null, null, null, null },
                    { "EG", null, null, "Egypt", null, null, null, null },
                    { "EH", null, null, "Western Sahara", null, null, null, null },
                    { "ER", null, null, "Eritrea", null, null, null, null },
                    { "ES", null, null, "Spain", null, null, null, null },
                    { "ET", null, null, "Ethiopia", null, null, null, null },
                    { "EU", null, null, "Europe", null, null, null, null },
                    { "FI", null, null, "Finland", null, null, null, null },
                    { "FJ", null, null, "Fiji", null, null, null, null },
                    { "FK", null, null, "Falkland Islands (Malvinas)", null, null, null, null },
                    { "FM", null, null, "Micronesia, Federated States of", null, null, null, null },
                    { "GS", null, null, "South Georgia and the South Sandwich Islands", null, null, null, null },
                    { "FO", null, null, "Faroe Islands", null, null, null, null },
                    { "GA", null, null, "Gabon", null, null, null, null },
                    { "GB", null, null, "United Kingdom", null, null, null, null },
                    { "GD", null, null, "Grenada", null, null, null, null },
                    { "GE", null, null, "Georgia", null, null, null, null },
                    { "GF", null, null, "French Guiana", null, null, null, null },
                    { "GG", null, null, "Guernsey", null, null, null, null },
                    { "GH", null, null, "Ghana", null, null, null, null },
                    { "GI", null, null, "Gibraltar", null, null, null, null },
                    { "GL", null, null, "Greenland", null, null, null, null },
                    { "GM", null, null, "Gambia", null, null, null, null },
                    { "GN", null, null, "Guinea", null, null, null, null },
                    { "GP", null, null, "Guadeloupe", null, null, null, null },
                    { "GQ", null, null, "Equatorial Guinea", null, null, null, null },
                    { "FR", null, null, "France", null, null, null, null },
                    { "ZW", null, null, "Zimbabwe", null, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "A1");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "A2");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "AZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "BZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CC");

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
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "CZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "DZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EE");

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
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ET");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "EU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "FI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "FJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "FK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "FM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "FO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GL");

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
                keyValue: "GP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "GY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "HK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "HM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "HN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "HR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "HT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "HU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ID");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "JE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "JM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "JO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "JP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "KZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LK");

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
                keyValue: "LT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "LV");

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
                keyValue: "MC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ME");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "ML");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MQ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "MY");

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
                keyValue: "NC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "NZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "O1");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "OM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "PY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "QA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "RW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SB");

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
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SM");

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
                keyValue: "SR");

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
                keyValue: "SV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "SZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "TZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "US");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "UZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "VU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "WF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "WS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "YE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryCode",
                keyValue: "YT");

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

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CountryISOCode",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryISOCode");
        }
    }
}
