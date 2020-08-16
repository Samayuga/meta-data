using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations
{
    public class ContinentEntityTypeConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasKey(c => c.ContinentId);
            builder.Property(c => c.ContinentName).IsRequired();

            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/1/"), ContinentName = "Africa" });
            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/2/"), ContinentName = "Antarctica" });
            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/3/"), ContinentName = "Asia" });
            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/4/"), ContinentName = "Europe" });
            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/5/"), ContinentName = "North America" });
            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/6/"), ContinentName = "South America" });
            builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/7/"), ContinentName = "Australia" });
        }
    }
}
