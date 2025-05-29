using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PetTrade.IDAL
{
    public class UserFactory
    {
        
        public static string ProjectName = ConfigurationManager.AppSettings["DAL"];
        public static IUserDao CreateUserService()
        {
            Console.WriteLine(ProjectName);
            Assembly assembly=Assembly.LoadFrom(ProjectName+".dll");
            if (assembly == null)
            {
                Console.WriteLine("null");
            }
            IUserDao iuserDao = (IUserDao)assembly.CreateInstance(ProjectName + ".UserDao");
            
            if (iuserDao == null)
                Console.WriteLine("null");
            return iuserDao;
        }

        public static IPetOwner CreatePetOwnerService()
        {
            Assembly assembly = Assembly.LoadFrom(ProjectName + ".dll");
            if (assembly == null)
            {
                Console.WriteLine("null");
            }
            IPetOwner iPetOwner = (IPetOwner)assembly.CreateInstance(ProjectName + ".PetOwner");

            if (iPetOwner == null)
                Console.WriteLine("null");
            return iPetOwner;
        }
    }
}
