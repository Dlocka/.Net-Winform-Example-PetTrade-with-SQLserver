using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetTrade.BLL;
using PetTrade.Models;
namespace PetTrade.UI
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string UserIdStr = Text_UserId.Text;
            string Password = Text_Password.Text;
            int UserId;
            object result = null;
            try
            {
                UserId = int.Parse(UserIdStr);
                UserManager userManager = new UserManager();
                result=userManager.Login(UserId, Password);
                if (result == null)
                {
                    MessageBox.Show("Login Failed");
                }
                else
                {
                    MessageBox.Show("Login Success");
                    tabControl_Main.Show();
                    //SetMyPetList();
                    Program.GetUser().UserId = UserId;
                    Program.GetUser().UserTypeId = 2; //设置用户类型
                    PetListSet(Program.GetUser());
                    PetPageFresh(Program.GetUser().PetList);//tabpage宠物显示刷新
                    
                }
              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        void RefreshPage_MyPet()
        {
            //ListView_MyPet.Items.Clear();
            PetListSet(Program.GetUser());
            PetPageFresh(Program.GetUser().PetList);
        }
        /// <summary>
        /// Refresh PetMarket,exclude logined user
        /// </summary>
        void RefreshPage_PetMarketWithOutUser()
        {
            List<Pet> PetList = new List<Pet>();
            PetOwner petOwner = new PetOwner();
            PetList = petOwner.GetPetsOnSale(false,Program.GetUser().UserId);
            PetPageFresh(listView_PetMarket, PetList, true, true, true, false, true);
        }
        /// <summary>
        /// Refresh PetMarket Page，Choose whether exclude a several user's pet data or only inlcude their data
        /// </summary>
        /// <param name="IsContain"></param>
        /// <param name="UserId"></param>
        void RefreshPage_PetMarket(bool IsContain,int UserId)
        {
            List<Pet> PetList = new List<Pet>();
            PetOwner petOwner = new PetOwner();
            PetList = petOwner.GetPetsOnSale(IsContain, UserId);
            PetPageFresh(listView_PetMarket, PetList, true, true, true, false, true);
        }
        /// <summary>
        /// 用户自己宠物petpage刷新
        /// </summary>
        /// <param name="PetList"></param>
        void PetPageFresh(List<Pet> PetList)
        {
            ListView_MyPet.Items.Clear();
            foreach (Pet pet in PetList)
            {
                
                   ListViewItem listViewitem = new ListViewItem();
                listViewitem.Text = pet.PetId.ToString();
                listViewitem.SubItems.AddRange(new string[]
                {
                    pet.PetName.ToString(),  Program.PetTypeExplay(pet.PetType),Program.PetSaleStatusExplay(pet.SaleStatus), pet.Price.ToString()
                });
                ListView_MyPet.Items.Add(listViewitem);
            }
        }
        /// <summary>
        /// 指定任意宠物界面的Listview更新
        /// </summary>
        /// <param name="listView">需要更新的ListView</param>
        /// <param name="PetList"></param>
        /// <param name="IsShowPetName"></param>
        /// <param name="IsShowPetType"></param>
        /// <param name="IsShowPetPossessor"></param>
        /// <param name="IsShowSaleStatus"></param>
        /// <param name="IsShowPrice"></param>
        void PetPageFresh(ListView listView,List<Pet> PetList, bool IsShowPetName, bool IsShowPetType, bool IsShowPetPossessor, bool IsShowSaleStatus, bool IsShowPrice)
        {
            listView.Items.Clear();
            foreach (Pet pet in PetList)
            {
                ListViewItem listViewitem = new ListViewItem();
                listViewitem.Text = pet.PetId.ToString();
                if (IsShowPetName)
                { listViewitem.SubItems.Add(pet.PetName.ToString()); }
                if(IsShowPetType)
                { listViewitem.SubItems.Add(Program.PetTypeExplay(pet.PetType)); }
                if (IsShowPetPossessor)
                { listViewitem.SubItems.Add(pet.PetPossessor.ToString()); }
                if(IsShowSaleStatus)
                { listViewitem.SubItems.Add(Program.PetSaleStatusExplay(pet.SaleStatus)); }
                if(IsShowPrice)
                { listViewitem.SubItems.Add(pet.Price.ToString()); }
                listView.Items.Add(listViewitem);
            }
        }
        /// <summary>
        /// Pass PetList to User Model it belonging to
        /// </summary>
        /// <param name="settedUser"></param>
        void PetListSet(User settedUser)
        {
            PetOwner petOwner = new PetOwner();
            settedUser.PetList = petOwner.GetPets(settedUser.UserId);
        }
        private void Text_UserId_TextChanged(object sender, EventArgs e)
     {

        }

        private void Password_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void ListView_MyPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
