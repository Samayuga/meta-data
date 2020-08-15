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
            SeedPlanets(modelBuilder);
        }

        private static void SeedPlanets(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().HasData(new Planet { PlanetId = HierarchyId.Parse("/1/"), PlanetName="Earth" });
        }
    }
}
