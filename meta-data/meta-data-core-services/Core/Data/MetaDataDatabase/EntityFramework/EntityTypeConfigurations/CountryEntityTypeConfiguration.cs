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

            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/1/"), CountryName = "Afghanistan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/2/"), CountryName = "Armenia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/3/"), CountryName = "Azerbaijan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/4/"), CountryName = "Bahrain" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/5/"), CountryName = "Bangladesh" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/6/"), CountryName = "Bhutan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/7/"), CountryName = "Brunei" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/8/"), CountryName = "Cambodia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/9/"), CountryName = "China" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/10/"), CountryName = "East Timor" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/11/"), CountryName = "Georgia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/12/"), CountryName = "India" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/13/"), CountryName = "Indonesia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/14/"), CountryName = "Iran" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/15/"), CountryName = "Iraq" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/16/"), CountryName = "Israel" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/17/"), CountryName = "Japan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/18/"), CountryName = "Jordan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/19/"), CountryName = "Kazakhstan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/20/"), CountryName = "Kuwait" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/21/"), CountryName = "Kyrgyzstan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/22/"), CountryName = "Laos" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/23/"), CountryName = "Lebanon" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/24/"), CountryName = "Malaysia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/25/"), CountryName = "Maldives" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/26/"), CountryName = "Mongolia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/27/"), CountryName = "Myanmar" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/28/"), CountryName = "Nepal" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/29/"), CountryName = "North Korea" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/30/"), CountryName = "Oman" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/31/"), CountryName = "Pakistan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/32/"), CountryName = "Philippines" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/33/"), CountryName = "Palestine" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/34/"), CountryName = "Qatar" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/35/"), CountryName = "Russia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/36/"), CountryName = "Saudi Arabia" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/37/"), CountryName = "Singapore" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/38/"), CountryName = "South Korea" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/39/"), CountryName = "Sri Lanka" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/40/"), CountryName = "Syria" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/41/"), CountryName = "Tajikistan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/42/"), CountryName = "Thailand" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/43/"), CountryName = "Turkey" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/44/"), CountryName = "Turkmenistan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/45/"), CountryName = "Taiwan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/46/"), CountryName = "United Arab Emirates" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/47/"), CountryName = "Uzbekistan" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/48/"), CountryName = "Vietnam" });
            builder.HasData(new Country { CountryId = HierarchyId.Parse("/1/3/49/"), CountryName = "Yemen" });
        }
    }
}
