using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Extentions
{
    public static class DatabaseExtentions
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<MetaDataDatabaseContext>();
                context.Database.Migrate();
            }

            return host;
        }

        public static IHost SeedDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<MetaDataDatabaseContext>();

                var x = context.Planets.ToList();
            }

            return host;
        }

        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
        }
    }
}
