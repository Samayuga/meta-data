using MetaDataEntityFrameworkCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDataEntityFrameworkCore.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        { }

        public DbSet<Continent> Continents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Continent>().Property(c => c.ContinentId).ValueGeneratedNever();
            builder.Entity<Continent>().Property(c => c.CommonName).HasMaxLength(50).IsRequired();
            builder.Entity<Continent>().Property(c => c.ImageUrl).HasMaxLength(250).IsRequired();
            builder.Entity<Continent>().Property(c => c.TwoLetterContinentCode).HasMaxLength(2).IsRequired();
            builder.Entity<Continent>().Property(c => c.InternetTLD).HasMaxLength(10).IsRequired();

            builder.Entity<Continent>().HasKey(c => c.ContinentId);
        }
    }
}
