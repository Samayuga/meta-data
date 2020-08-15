using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities
{
    public class Planet
    {
        public HierarchyId PlanetId { get; set; }
        public string PlanetName { get; set; }
    }
}
