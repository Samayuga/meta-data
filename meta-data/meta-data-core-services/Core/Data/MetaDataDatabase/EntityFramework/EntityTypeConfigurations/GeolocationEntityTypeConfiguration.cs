using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations
{
    public class GeolocationEntityTypeConfiguration : IEntityTypeConfiguration<Geolocation>
    {
        public void Configure(EntityTypeBuilder<Geolocation> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Type).IsRequired();

            builder.HasKey(c => c.Id);
        }
    }
}
