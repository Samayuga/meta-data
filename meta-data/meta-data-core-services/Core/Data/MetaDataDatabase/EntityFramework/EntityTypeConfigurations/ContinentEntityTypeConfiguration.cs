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
            builder.HasKey(c => c.ContinentCode);
            builder.Property(c => c.ContinentName).IsRequired();

            builder.HasData(new Continent { ContinentCode = "AF", ContinentName = "Africa" });
            builder.HasData(new Continent { ContinentCode = "AN", ContinentName = "Antarctica" });
            builder.HasData(new Continent { ContinentCode = "AS", ContinentName = "Asia" });
            builder.HasData(new Continent { ContinentCode = "EU", ContinentName = "Europe" });
            builder.HasData(new Continent { ContinentCode = "NA", ContinentName = "North America" });
            builder.HasData(new Continent { ContinentCode = "OC", ContinentName = "Oceania" });
            builder.HasData(new Continent { ContinentCode = "SA", ContinentName = "South America" });
        }
    }
}
