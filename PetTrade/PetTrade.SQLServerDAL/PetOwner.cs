using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrade.IDAL;
using PetTrade.Models;
using System.Windows.Forms;
namespace PetTrade.SQLServerDAL
{
    class PetOwner : IPetOwner
    {

        public object PetBuy(int PetId, int BuyerId)
        { SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@UserId", BuyerId),
           new SqlParameter("@PetId", PetId)
           };
            foreach (var item in sqlParameters)
            {
                Console.WriteLine(item);
            }
            Object obj = DBHelper.ExecuteTransactionWithReturn("dbo.BuyPet", sqlParameters);
            return obj;
        }
        public object AddPet(int PetType, int PossessorId, float Price)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@PetType", PetType),
           new SqlParameter("@PossessorId", PossessorId),
           new SqlParameter("@Price",Price)
           };
            foreach (var item in sqlParameters)
            {
                Console.WriteLine(item);
            }
            Object obj = DBHelper.ExecuteTransactionWithReturn("dbo.AddPet", sqlParameters);
            return obj;
        }

        public List<Pet> GetPets(int PetPossessor)
        {
            string sqlquery = "Select * from Pet where PetPossessor=@PetPossessor";
            SqlParameter[] sqlParameters= new SqlParameter[] {
            new SqlParameter("@PetPossessor", PetPossessor)
           };
            DataSet ds =DBHelper.GetDataSet(sqlquery, sqlParameters);
            DataTable dataTable = ds.Tables[0];
            List<Pet> PetList = new List<Pet>();
            foreach (DataRow row in dataTable.Rows)
            {
                Pet pet = new Pet();
                try
                { 
                pet.PetId = (int)row.ItemArray[0];
                    pet.PetName = row.ItemArray[1].ToString();
                    pet.PetType = (int)row.ItemArray[2];
                    pet.PetPossessor = (int)row.ItemArray[3];
                    pet.SaleStatus= (int)row.ItemArray[4];
                    pet.Price = (int)row.ItemArray[5];
                    PetList.Add(pet);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return PetList;
        }
        public List<Pet> GetPetsOnSale()
        {
            string sqlquery = "Select * from Pet where SaleStatus=1";
          
            DataSet ds = DBHelper.GetDataSet(sqlquery);
            DataTable dataTable = ds.Tables[0];
            List<Pet> PetList = new List<Pet>();
            foreach (DataRow row in dataTable.Rows)
            {
                Pet pet = new Pet();
                try
                {
                    pet.PetId = (int)row.ItemArray[0];
                    pet.PetName = row.ItemArray[1].ToString();
                    pet.PetType = (int)row.ItemArray[2];
                    pet.PetPossessor = (int)row.ItemArray[3];
                    pet.SaleStatus = (int)row.ItemArray[4];
                    pet.Price = (int)row.ItemArray[5];
                    PetList.Add(pet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return PetList;
        }

        public List<Pet> GetPetsOnSale(bool IsConatin, int UserId)
        {

            SqlParameter[] sqlParameters = new SqlParameter[] {
            new SqlParameter("@UserID", UserId)
           };
            string sqlquery = "Select * from Pet where SaleStatus in (1) and PetPossessor";
            string id = UserId.ToString();
            if (IsConatin)
            {
                sqlquery = sqlquery+" in (@UserID)";
              }
            else
            {
                sqlquery = sqlquery + " not in (@UserID)";
            }
            DataSet ds = DBHelper.GetDataSet(sqlquery,sqlParameters);
            DataTable dataTable = ds.Tables[0];
            List<Pet> PetList = new List<Pet>();
            foreach (DataRow row in dataTable.Rows)
            {
                Pet pet = new Pet();
                try
                {
                    pet.PetId = (int)row.ItemArray[0];
                    pet.PetName = row.ItemArray[1].ToString();
                    pet.PetType = (int)row.ItemArray[2];
                    pet.PetPossessor = (int)row.ItemArray[3];
                    pet.SaleStatus = (int)row.ItemArray[4];
                    pet.Price = (int)row.ItemArray[5];
                    PetList.Add(pet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return PetList;
        }
    }
}
