using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.MetaDataDatabaseContext
{
    public class MetaDataDatabaseContext : DbContext
    {
        public MetaDataDatabaseContext(DbContextOptions<MetaDataDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Table1> Table1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table1>().ToTable("Table1");
        }
    }
}
