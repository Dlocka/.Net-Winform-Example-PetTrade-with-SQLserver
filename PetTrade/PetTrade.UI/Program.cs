using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetTrade.Models;
namespace PetTrade.UI
{
    static class Program
    {
        static User user=new User();
        public static User GetUser()
        {
            if (user == null)
            {
                user = new User();
                return user;
            }
            else
            {
                return user;
            }
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        public static string PetSaleStatusExplay(int SaleStatus)
        {
            string explayStr="未知";
            if(SaleStatus==1)
            {
                explayStr = "在售";
            }
            else if(SaleStatus == 2)
            {
                explayStr = "未在售";
            }
            return explayStr;
        }
        public static string PetTypeExplay(int PetType)
        {
            string explayStr = "未知";
            if (PetType == 1)
            {
                explayStr = "狗";
            }
            else if (PetType == 2)
            {
                explayStr = "猫";
            }
            return explayStr;
        }
    }
}
