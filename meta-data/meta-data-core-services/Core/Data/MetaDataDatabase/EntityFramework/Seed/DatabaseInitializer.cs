using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities;
using MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Entities.MetaDataDatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDataCoreServices.Core.Data.MetaDataDatabase.EntityFramework.Seed
{
    public static class DatabaseInitializer
    {
        public static void Initialize(MetaDataDatabaseContext context)
        {
            //context.Database.EnsureCreated();

            if (context.Table1.Any())
                return;   

            var data = new Table1[]
            {
                new Table1{Id=1,Column1="C1",Column2="C2"},
                new Table1{Id=2,Column1="C1",Column2="C2"},
            };

            context.Table1.AddRange(data);
            context.SaveChanges();
        }
    }
}
