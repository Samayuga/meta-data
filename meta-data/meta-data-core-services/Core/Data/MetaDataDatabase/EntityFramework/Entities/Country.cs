﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities
{
    public partial class Country
    {
        public string CountryISOCode { get; set; }
        public string CountryName { get; set; }
        public string Capital { get; set; }
        public string Flag { get; set; }
        public string OrthographicMap { get; set; }
        public string CallingCode { get; set; }
        public string ISOCode { get; set; }
        public string CurrencyISOCode { get; set; }
    }

    public partial class Country
    {
        public Currency Currency { get; set; }
    }
}
