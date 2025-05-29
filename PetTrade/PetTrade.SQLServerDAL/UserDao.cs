using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrade.IDAL;

namespace PetTrade.SQLServerDAL
{
    class UserDao : IUserDao
    {
        public void ConnectionTest()
        {
            DBHelper.TestConnection();
        }

        public object Login(int UserId, string Password)
        { SqlParameter[] sqlParameters = 
           new SqlParameter[] { new SqlParameter("@userid", UserId),
           new SqlParameter("@password", Password)
           };
            object obj=DBHelper.ExecuteScalar("select * from UserInfos where UserId=@userid and Password=@password", sqlParameters);
            return obj;
        }
    }

    
}
