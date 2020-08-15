using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations
{
    public class PlanetEntityTypeConfiguration : IEntityTypeConfiguration<Planet>
    {
        public void Configure(EntityTypeBuilder<Planet> builder)
        {
            builder.HasKey(c => c.PlanetId);
            builder.Property(c => c.PlanetName).IsRequired();

            builder.HasData(new Planet { PlanetId = HierarchyId.Parse("/1/"), PlanetName = "Earth" });
        }
    }
}
