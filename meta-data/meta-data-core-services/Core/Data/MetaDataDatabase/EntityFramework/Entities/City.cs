using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities
{
    public class City
    {
        public HierarchyId CityId { get; set; }
        public string CityName { get; set; }
    }
}
