using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrade.BLL;
using PetTrade.Models;
namespace PetTrade.UI
{
   class Program
    {
        static User user=new User();
        static void Main(string[] args)
        {
            //Program.TestConnection();
            //Console.ReadKey();
            Login();
            ChooseFunction();
            Console.ReadKey();
        }
        static void Login()
        {
            Console.WriteLine("Please input Account");
            try
            {
                string useIdstring = Console.ReadLine();
                int userId = int.Parse(useIdstring);
                user.UserId = userId;
                Console.WriteLine("Please input Password");
                string password = Console.ReadLine();
                Console.WriteLine("登录数据接收");
                UserManager userManager = new UserManager();
                Object testobj=userManager.Login(userId, password);
                if(testobj==null)
                {
                    Console.WriteLine("Login Failed");
                    Login();
                }
                else {
                    Console.WriteLine("Login Success");
                  user.UserId = userId;
                    user.UserTypeId = 2;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Login();
            }

        }
        static void BuyPet()
        {
            PetOwner petOwner = new PetOwner();
            Console.WriteLine("Input PetId you want to buy");
            int petid=0;
            try { 
             petid = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            object obj=petOwner.PetBuy(petid, user.UserId);
            int result=-1000;
            try { result = (int)obj;
                if (result == 1)
                {
                    Console.WriteLine("Purchase sucess");
                }
                else if (result == 0)
                { Console.WriteLine("Purchase failed, not enough fund"); }
                else if (result == -1)
                {
                    Console.WriteLine("Pet not existed");
                }
                else if (result == -2)
                {
                    Console.WriteLine("Couldn't buy pet you've already owned");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { ChooseFunction(); }
            
        }
        static void TestConnection()
        {
            UserManager userManager = new UserManager();
            userManager.ConnectionTest();
        }
       static void ListPet()
        {
            Console.WriteLine("Input PetId listed");
        }
        static void ChooseFunction()
        {
            Console.WriteLine("Select Action:press 1 to buy pet, press 2 to list pet, press 3 to add pet");
            try
            { 
            int Press = int.Parse(Console.ReadLine());
                switch (Press)
                {
                    case 1:BuyPet();break;
                    case 2:ListPet();break;
                    case 3:AddPet();break;
                    default:Console.WriteLine("Input again");
                                ChooseFunction();
                                break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void AddPet()
        {
            Console.WriteLine("Input pet type");
            string PetTypeInput=Console.ReadLine();
            int PetType;
            Console.WriteLine("Input price");
            string PriceInput = Console.ReadLine();
            float Price;
            try
            { PetType = int.Parse(PetTypeInput);
                Price= int.Parse(PriceInput);
                PetOwner petOwner = new PetOwner();
               int result = (int)petOwner.AddPet(PetType, user.UserId,Price);
                if(result==1)
                { Console.WriteLine("Add successfully"); }
                else
                {
                    Console.WriteLine("Add failure");
                }
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); 
              }
            finally { ChooseFunction(); }
        }
    }
}
