using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MetaDataCoreServices.Core.Data.MetaDataDatabase;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Extentions;

namespace MetaDataCoreServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().MigrateDatabase().SeedDatabase().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
