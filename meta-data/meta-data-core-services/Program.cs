using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.MetaDataDatabaseContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Seed;

namespace MetaDataCoreServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            SeedDatabase(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

        private static void SeedDatabase(IHost host)
        {
            using var serviceScope = host.Services.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;

            try
            {
                var context = serviceProvider.GetRequiredService<MetaDataDatabaseContext>();
                DatabaseInitializer.Initialize(context);
            }
            catch (Exception exception)
            {
                var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                logger.LogError(exception, exception.Message);
            }
        }
    }
}
