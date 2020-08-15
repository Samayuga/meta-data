using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Seed_GeolocationTypes(modelBuilder);
        }

        private static void Seed_GeolocationTypes(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<GeolocationType>().HasData(new GeolocationType { Id= HierarchyId.Parse("/1/"), Name="" });
        }
    }
}
