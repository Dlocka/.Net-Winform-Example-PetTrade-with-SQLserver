using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.IDAL
{
    public interface IUserDao
    {
         void ConnectionTest();
        object Login(int UserId, string Name);
    }
}
