using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations
{
    public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.CountryId);
            builder.Property(c => c.CountryName).IsRequired();

            //builder.HasData(new Continent { ContinentId = HierarchyId.Parse("/1/3/91"), ContinentName = "India" });
        }
    }
}
