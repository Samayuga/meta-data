using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.EntityTypeConfigurations;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Extentions;
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

        public DbSet<Continent> Continents { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContinentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CountryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PlanetEntityTypeConfiguration());

            modelBuilder.SeedDatabase();
        }
    }
}
