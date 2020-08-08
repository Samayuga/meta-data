using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations
{
    public class GeolocationTypeEntityTypeConfiguration : IEntityTypeConfiguration<GeolocationType>
    {
        public void Configure(EntityTypeBuilder<GeolocationType> builder)
        {
            builder.HasKey(c => c.Name);
        }
    }
}
