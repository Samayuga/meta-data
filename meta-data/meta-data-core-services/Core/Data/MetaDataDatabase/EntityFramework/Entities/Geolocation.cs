﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities
{
    public class Geolocation
    {
        public HierarchyId Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
