using Microsoft.EntityFrameworkCore.Migrations;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    public partial class SeedingCurrencyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyISOCode", "BaseNumber", "FractionalUnit", "Name", "Symbol" },
                values: new object[,]
                {
                    { "AED", 100, "Fils", "United Arab Emirates dirham", "د.إ" },
                    { "NGN", 100, "Kobo", "Nigerian naira", "₦" },
                    { "NOK", 100, "Øre", "Norwegian krone", "kr" },
                    { "NPR", 100, "Paisa", "Nepalese rupee", "रू" },
                    { "OMR", 100, "Baisa", "Omani rial", "ر.ع." },
                    { "PKR", 100, "Paisa", "Pakistani rupee", "₨" },
                    { "PAB", 100, "Centésimo", "Panamanian balboa", "B/." },
                    { "PGK", 100, "Toea", "Papua New Guinean kina", "K" },
                    { "NIO", 100, "Centavo", "Nicaraguan córdoba", "C$" },
                    { "PEN", 100, "Céntimo", "Peruvian sol", "S/." },
                    { "PLN", 100, "Grosz", "Polish złoty", "zł" },
                    { "NZD", 100, "Cent", "New Zealand dollar", "$" },
                    { "PND", 100, "Cent", "Pitcairn Islands dollar", "$" },
                    { "PYG", 100, "Céntimo", "Paraguayan guaraní", "₲" },
                    { "QAR", 100, "Dirham", "Qatari riyal", "ر.ق" },
                    { "RON", 100, "Ban", "Romanian leu", "lei" },
                    { "RSD", 100, "Para", "Serbian dinar", "дин" },
                    { "PHP", 100, "Sentimo", "Philippine peso", "₱" },
                    { "NAD", 100, "Cent", "Namibian dollar", "$" },
                    { "MZN", 100, "Centavo", "Mozambican metical", "MT" },
                    { "MXN", 100, "Centavo", "Mexican peso", "$" },
                    { "LBP", 100, "Piastre", "Lebanese pound", "ل.ل" },
                    { "LRD", 100, "Cent", "Liberian dollar", "$" },
                    { "LKR", 100, "Cent", "Sri Lankan rupee", "ரூ" },
                    { "LSL", 100, "Sente", "Lesotho loti", "L" },
                    { "LYD", 100, "Dirham", "Libyan dinar", "ل.د" },
                    { "MGA", 100, "Iraimbilanja", "Malagasy ariary", "Ar" },
                    { "MDL", 100, "Ban", "Moldovan leu", "L" },
                    { "MAD", 100, "Centime", "Moroccan dirham", "د.م." },
                    { "MOP", 100, "Avo", "Macanese pataca", "P" },
                    { "MRU", 100, "Khoums", "Mauritanian ouguiya", "UM" },
                    { "MNT", 100, "Möngö", "Mongolian tögrög", "₮" },
                    { "MMK", 100, "Pya", "Burmese kyat", "Ks" },
                    { "MKD", 100, "Deni", "Macedonian denar", "ден" },
                    { "MWK", 100, "Tambala", "Malawian kwacha", "MK" },
                    { "MYR", 100, "Sen", "Malaysian ringgit", "RM" },
                    { "MVR", 100, "Laari", "Maldivian rufiyaa", ".ރ" },
                    { "MUR", 100, "Cent", "Mauritian rupee", "₨" },
                    { "PRB", 100, "Kopek", "Transnistrian ruble", "р." },
                    { "RUB", 100, "Kopek", "Russian ruble", "₽" },
                    { "RWF", 100, "Centime", "Rwandan franc", "Fr" },
                    { "SAR", 100, "Halala", "Saudi riyal", "﷼‎" },
                    { "TZS", 100, "Cent", "Tanzanian shilling", "Sh" },
                    { "TTD", 100, "Cent", "Trinidad and Tobago dollar", "$" },
                    { "TVD", 100, "Cent", "Tuvaluan dollar", "$" },
                    { "UAH", 100, "Kopiyka", "Ukrainian hryvnia", "₴" },
                    { "USD", 100, "Cent", "United States dollar", "$" },
                    { "UGX", 100, "Cent", "Ugandan shilling", "Sh" },
                    { "UYU", 100, "Centésimo", "Uruguayan peso", "$" },
                    { "UZS", 100, "Tiyin", "Uzbekistani soʻm", "сўм" },
                    { "VES", 100, "Céntimo", "Venezuelan bolívar soberano", "Bs." },
                    { "VND", 100, "Hào", "Vietnamese đồng", "₫" },
                    { "XCD", 100, "Cent", "Eastern Caribbean dollar", "$" },
                    { "XOF", 100, "Centime", "West African CFA franc", "Fr" },
                    { "XAF", 100, "Centime", "Central African CFA franc", "Fr" },
                    { "XPF", 100, "Centime", "CFP franc", "₣" },
                    { "WST", 100, "Sene", "Samoan tālā", "T" },
                    { "VUV", 100, "", "Vanuatu vatu", "Vt" },
                    { "ZAR", 100, "Cent", "South African rand", "R" },
                    { "TWD", 100, "Cent", "New Taiwan dollar", "$" },
                    { "LAK", 100, "Att", "Lao kip", "₭" },
                    { "TRY", 100, "Kuruş", "Turkish lira", "₺" },
                    { "TND", 100, "Millime", "Tunisian dinar", "د.ت" },
                    { "SCR", 100, "Cent", "Seychellois rupee", "₨" },
                    { "SBD", 100, "Cent", "Solomon Islands dollar", "$" },
                    { "SHP", 100, "Penny", "Saint Helena pound", "£" },
                    { "SGD", 100, "Cent", "Singapore dollar", "$" },
                    { "SLL", 100, "Cent", "Sierra Leonean leone", "Le" },
                    { "SDG", 100, "Piastre", "Sudanese pound", "ج.س." },
                    { "SEK", 100, "Öre", "Swedish krona", "kr" },
                    { "STN", 100, "Cêntimo", "São Tomé and Príncipe dobra", "Db" },
                    { "SOS", 100, "Cent", "Somali shilling", "Sh" },
                    { "SLS", 100, "Cent", "Somaliland shilling", "Sl" },
                    { "SSP", 100, "Piaster", "South Sudanese pound", "£" },
                    { "SRD", 100, "Cent", "Surinamese dollar", "$" },
                    { "SYP", 100, "Piastre", "Syrian pound", "ل.س" },
                    { "SZL", 100, "Cent", "Swazi lilangeni", "L" },
                    { "TJS", 100, "Diram", "Tajikistani somoni", "ЅМ" },
                    { "THB", 100, "Satang", "Thai baht", "฿" },
                    { "TOP", 100, "Seniti", "Tongan paʻanga", "T$" },
                    { "TMT", 100, "Tennesi", "Turkmenistan manat", "m" },
                    { "YER", 100, "Fils", "Yemeni rial", "ر.ي" },
                    { "KZT", 100, "Tıyn", "Kazakhstani tenge", "₸" },
                    { "KWD", 100, "Fils", "Kuwaiti dinar", "د.ك" },
                    { "BWP", 100, "Thebe", "Botswana pula", "P" },
                    { "BYN", 100, "Kapyeyka", "Belarusian ruble", "Br" },
                    { "BZD", 100, "Cent", "Belize dollar", "$" },
                    { "CAD", 100, "Cent", "Canadian dollar", "$" },
                    { "CDF", 100, "Centime", "Congolese franc", "Fr" },
                    { "CHF", 100, "Rappen", "Swiss franc", "Fr." },
                    { "CLP", 100, "Centavo", "Chilean peso", "$" },
                    { "BTN", 100, "Chetrum", "Bhutanese ngultrum", "Nu." },
                    { "CNY", 10, "Jiao", "Chinese yuan", "¥" },
                    { "COP", 100, "Centavo", "Colombian peso", "$" },
                    { "CRC", 100, "Céntimo", "Costa Rican colón", "₡" },
                    { "CUC", 100, "Centavo", "Cuban convertible peso", "$" },
                    { "CVE", 100, "Centavo", "Cape Verdean escudo", "Esc" },
                    { "CUP", 100, "Centavo", "Cuban peso", "$" },
                    { "CZK", 100, "Haléř", "Czech koruna", "Kč" },
                    { "DJF", 100, "Centime", "Djiboutian franc", "Fr" },
                    { "CKD", 100, "Cent", "Cook Islands dollar", "$" },
                    { "BSD", 100, "Cent", "Bahamian dollar", "$" },
                    { "BRL", 100, "Centavo", "Brazilian real", "R$" },
                    { "BOB", 100, "Centavo", "Bolivian boliviano", "Bs." },
                    { "AFN", 100, "Pul", "Afghan afghani", "؋" },
                    { "ALL", 100, "Qindarkë", "Albanian lek", "L" },
                    { "AMD", 100, "Luma", "Armenian dram", "֏" },
                    { "ANG", 100, "Cent", "Netherlands Antillean guilder", "ƒ" },
                    { "AOA", 100, "Cêntimo", "Angolan kwanza", "Kz" },
                    { "ARS", 100, "Centavo", "Argentine peso", "$" },
                    { "AUD", 100, "Cent", "Australian dollar", "$" },
                    { "AWG", 100, "Cent", "Aruban florin", "ƒ" },
                    { "AZN", 100, "Qəpik", "Azerbaijani manat", "₼" },
                    { "BAM", 100, "Fening", "Bosnia and Herzegovina convertible mark", "KM" },
                    { "BBD", 100, "Cent", "Barbadian dollar", "$" },
                    { "BDT", 100, "Poisha", "Bangladeshi taka", "৳" },
                    { "BGN", 100, "Stotinka", "Bulgarian lev", "лв." },
                    { "BHD", 100, "Fils", "Bahraini dinar", ".د.ب" },
                    { "BIF", 100, "Centime", "Burundian franc", "Fr" },
                    { "BMD", 100, "Cent", "Bermudian dollar", "$" },
                    { "BND", 100, "Sen", "Brunei dollar", "$" },
                    { "DZD", 100, "Santeem", "Algerian dinar", "د.ج" },
                    { "DKK", 100, "Øre", "Danish krone", "kr" },
                    { "DOP", 100, "Centavo", "Dominican peso", "$" },
                    { "EGP", 100, "Piastre", "Egyptian pound", "£" },
                    { "IDR", 100, "Sen", "Indonesian rupiah", "Rp" },
                    { "IMP", 100, "Penny", "Manx pound", "£" },
                    { "ILS", 100, "Agora", "Israeli new shekel", "₪" },
                    { "ISK", 100, "Eyrir", "Icelandic króna", "kr" },
                    { "IRR", 100, "Rial", "Iranian rial", "﷼" },
                    { "IQD", 100, "Fils", "Iraqi dinar", "ع.د" },
                    { "JEP", 100, "Penny", "Jersey pound", "£" },
                    { "JMD", 100, "Cent", "Jamaican dollar", "$" },
                    { "JPY", 100, "Sen", "Japanese yen", "¥" },
                    { "JOD", 100, "Piastre", "Jordanian dinar", "د.ا" },
                    { "KES", 100, "Cent", "Kenyan shilling", "Sh" },
                    { "KGS", 100, "Tyiyn", "Kyrgyzstani som", "с" },
                    { "KHR", 100, "Sen", "Cambodian riel", "៛" },
                    { "KMF", 100, "Centime", "Comorian franc", "Fr" },
                    { "KID", 100, "Cent", "Kiribati dollar", "$" },
                    { "KPW", 100, "Chon", "North Korean won", "₩" },
                    { "KRW", 100, "Jeon", "South Korean won", "₩" },
                    { "INR", 100, "Paisa", "Indian rupee", "₹" },
                    { "KYD", 100, "Cent", "Cayman Islands dollar", "$" },
                    { "HUF", 100, "Fillér", "Hungarian forint", "Ft" },
                    { "HRK", 100, "Lipa", "Croatian kuna", "kn" },
                    { "ERN", 100, "Cent", "Eritrean nakfa", "Nfk" },
                    { "ETB", 100, "Santim", "Ethiopian birr", "Br" },
                    { "EUR", 100, "Cent", "Euro", "€" },
                    { "FKP", 100, "Penny", "Falkland Islands pound", "£" },
                    { "FOK", 100, "Oyra", "Faroese króna", "kr" },
                    { "FJD", 100, "Cent", "Fijian dollar", "$" },
                    { "GBP", 100, "Penny", "British pound", "£" },
                    { "GGP", 100, "Penny", "Guernsey pound", "£" },
                    { "GEL", 100, "Tetri", "Georgian lari", "₾" },
                    { "GMD", 100, "Butut", "Gambian dalasi", "D" },
                    { "GHS", 100, "Pesewa", "Ghanaian cedi", "₵" },
                    { "GIP", 100, "Penny", "Gibraltar pound", "£" },
                    { "GNF", 100, "Centime", "Guinean franc", "Fr" },
                    { "GTQ", 100, "Centavo", "Guatemalan quetzal", "Q" },
                    { "GYD", 100, "Cent", "Guyanese dollar", "$" },
                    { "HNL", 100, "Centavo", "Honduran lempira", "L" },
                    { "HKD", 100, "Cent", "Hong Kong dollar", "$" },
                    { "HTG", 100, "Centime", "Haitian gourde", "G" },
                    { "ZMW", 100, "Ngwee", "Zambian kwacha", "ZK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AED");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AFN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ALL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AMD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ANG");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AOA");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ARS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AUD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AWG");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "AZN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BAM");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BBD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BDT");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BGN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BHD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BIF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BMD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BND");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BOB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BRL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BSD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BTN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BWP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BYN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "BZD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CAD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CDF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CHF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CKD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CLP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CNY");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "COP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CRC");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CUC");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CUP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CVE");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "CZK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "DJF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "DKK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "DOP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "DZD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "EGP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ERN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ETB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "EUR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "FJD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "FKP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "FOK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GBP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GEL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GGP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GHS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GIP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GMD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GNF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GTQ");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "GYD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "HKD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "HNL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "HRK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "HTG");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "HUF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "IDR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ILS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "IMP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "INR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "IQD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "IRR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ISK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "JEP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "JMD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "JOD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "JPY");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KES");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KGS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KHR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KID");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KMF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KPW");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KRW");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KWD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KYD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "KZT");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LAK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LBP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LKR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LRD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LSL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "LYD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MAD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MDL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MGA");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MKD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MMK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MNT");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MOP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MRU");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MUR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MVR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MWK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MXN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MYR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "MZN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "NAD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "NGN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "NIO");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "NOK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "NPR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "NZD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "OMR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PAB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PEN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PGK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PHP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PKR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PLN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PND");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PRB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "PYG");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "QAR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "RON");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "RSD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "RUB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "RWF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SAR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SBD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SCR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SDG");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SEK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SGD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SHP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SLL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SLS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SOS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SRD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SSP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "STN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SYP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "SZL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "THB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TJS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TMT");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TND");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TOP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TRY");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TTD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TVD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TWD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "TZS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "UAH");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "UGX");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "USD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "UYU");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "UZS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "VES");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "VND");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "VUV");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "WST");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "XAF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "XCD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "XOF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "XPF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "YER");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ZAR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyISOCode",
                keyValue: "ZMW");
        }
    }
}
