 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dewei.DALFactory;
using Dewei.EFDAL;
using Dewei.IBLL;
using Dewei.IDAL;
using Dewei.Model;

namespace Dewei.BLL
{
	
	public partial class UserService:BaseService<User>,IUserService //crud
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UserDal;
        } 
	}
}