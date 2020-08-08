﻿using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework
{
    public class MetaDataDatabaseContext : DbContext
    {
        public MetaDataDatabaseContext(DbContextOptions<MetaDataDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<GeolocationType> GeolocationTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GeolocationTypeEntityTypeConfiguration());
        }
    }
}