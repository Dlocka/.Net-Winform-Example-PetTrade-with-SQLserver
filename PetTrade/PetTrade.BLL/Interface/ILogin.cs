using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.BLL.Interface
{
    interface ILogin
    {
        object Login (int UserId,string Password);
    }
}
