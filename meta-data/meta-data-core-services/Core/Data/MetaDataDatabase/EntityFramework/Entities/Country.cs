using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities
{
    public class Country
    {
        public HierarchyId CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
