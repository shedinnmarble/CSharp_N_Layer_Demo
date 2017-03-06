using Dewei.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Dewei.EFDAL
{
    public class DbContextFactory
    {
        public static DbContext GetCurrentDbContext()
        {
            
            //Use one instance per request.
            DbContext db = CallContext.GetData("DbContext") as DbContext;
            if (db == null)
            {
                db = new DeweiEntities();
                CallContext.SetData("DbContext", db);
            }
            return db;
        }

    }
}
