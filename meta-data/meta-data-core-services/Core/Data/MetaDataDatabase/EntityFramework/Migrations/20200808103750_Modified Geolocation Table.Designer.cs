﻿// <auto-generated />
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Migrations
{
    [DbContext(typeof(MetaDataDatabaseContext))]
    [Migration("20200808103750_Modified Geolocation Table")]
    partial class ModifiedGeolocationTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.Geolocation", b =>
                {
                    b.Property<HierarchyId>("Id")
                        .HasColumnType("hierarchyid");

                    b.Property<HierarchyId>("GeolocationTypeId")
                        .IsRequired()
                        .HasColumnType("hierarchyid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeolocationTypeId");

                    b.ToTable("Geolocations");
                });

            modelBuilder.Entity("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.GeolocationType", b =>
                {
                    b.Property<HierarchyId>("Id")
                        .HasColumnType("hierarchyid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GeolocationTypes");
                });

            modelBuilder.Entity("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.Geolocation", b =>
                {
                    b.HasOne("MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.GeolocationType", "GeolocationType")
                        .WithMany()
                        .HasForeignKey("GeolocationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}