using PetTrade.BLL.Interface;
using PetTrade.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.BLL
{
    public class UserManager: IUserDao
    {
        private readonly IUserDao iUserDao = UserFactory.CreateUserService();
        
        public void ConnectionTest()
        {
            iUserDao.ConnectionTest();
        }

        public object Login(int UserId, string Password)
        {
           Object obj_bll= iUserDao.Login(UserId, Password);
            return obj_bll;
        }
    }

    
}
