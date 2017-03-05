 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dewei.EFDAL;
using Dewei.IDAL;


namespace Dewei.DALFactory
{
    /// <summary>
    /// 由简单工厂转变成了抽象工厂。
    /// 抽象工厂  VS  简单工厂
    /// 
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