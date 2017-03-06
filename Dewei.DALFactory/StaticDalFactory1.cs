 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dewei.IDAL;


namespace Dewei.DALFactory
{
    /// <summary>
    /// Abstract factory
    /// </summary>
    public partial class StaticDalFactory
    {
   
	
		public static IUserDal GetUserDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UserDal")
				as IUserDal;
		}
	}
}