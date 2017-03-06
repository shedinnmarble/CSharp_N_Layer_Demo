using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dewei.IDAL;

namespace Dewei.DALFactory
{
    public partial class DbSession : IDbSession
    {
        public int SaveChanges()
        {
            return DbSessionFactory.GetCurrentDbSession().SaveChanges();
        }
    }
}
