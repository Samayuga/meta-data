using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities
{
    public class Currency
    {
        public HierarchyId CurrencyId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string ISOCode { get; set; }
        public string FractionalUnit { get; set; }
        public int? BaseNumber { get; set; }
    }
}
