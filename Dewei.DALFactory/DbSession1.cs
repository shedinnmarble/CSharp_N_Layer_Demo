 
using Dewei.IDAL;

namespace Dewei.DALFactory
{
    public partial class DbSession :IDbSession
    {
   
		
	public IUserDal UserDal
    {
        get { return StaticDalFactory.GetUserDal(); }
    }
	}
}