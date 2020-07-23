using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDataEntityFrameworkCore.Database.Entities
{
    public class Continent
    {
        public byte? ContinentId { get; set; }
        public string CommonName { get; set; }
        public string InternetTLD { get; set; }
        public string ImageUrl { get; set; }
        public string TwoLetterContinentCode { get; set; }
    }
}
