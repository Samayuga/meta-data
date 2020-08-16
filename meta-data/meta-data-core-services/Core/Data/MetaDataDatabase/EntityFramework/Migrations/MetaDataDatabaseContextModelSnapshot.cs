﻿// <auto-generated />
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    [DbContext(typeof(MetaDataDatabaseContext))]
    partial class MetaDataDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.Continent", b =>
                {
                    b.Property<HierarchyId>("ContinentId")
                        .HasColumnType("hierarchyid");

                    b.Property<string>("ContinentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContinentId");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/1/"),
                            ContinentName = "Africa"
                        },
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/2/"),
                            ContinentName = "Antarctica"
                        },
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/3/"),
                            ContinentName = "Asia"
                        },
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/4/"),
                            ContinentName = "Europe"
                        },
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/5/"),
                            ContinentName = "North America"
                        },
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/6/"),
                            ContinentName = "South America"
                        },
                        new
                        {
                            ContinentId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/7/"),
                            ContinentName = "Australia"
                        });
                });

            modelBuilder.Entity("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.Country", b =>
                {
                    b.Property<HierarchyId>("CountryId")
                        .HasColumnType("hierarchyid");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.Planet", b =>
                {
                    b.Property<HierarchyId>("PlanetId")
                        .HasColumnType("hierarchyid");

                    b.Property<string>("PlanetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlanetId");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            PlanetId = Microsoft.EntityFrameworkCore.HierarchyId.Parse("/1/"),
                            PlanetName = "Earth"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
