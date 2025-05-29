using PetTrade.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.OracleDAL
{
    public class UserDao : IUserDao
    {
        
        public void ConnectionTest()
        {
            //Console.WriteLine(DBHelper.connStr);
            DBHelper.TestConnection();
        }

        public object Login(int UserId, string Name)
        {
            return  new object();
        }
    }
}
