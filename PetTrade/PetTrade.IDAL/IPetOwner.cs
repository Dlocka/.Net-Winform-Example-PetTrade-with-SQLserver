using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrade.Models;
namespace PetTrade.IDAL
{
    public interface IPetOwner
    {
        object PetBuy(int PetId, int BuyerId);
        object AddPet(int PetType,int PossessorId, float price);
        List<Pet> GetPets(int PetPossessor);
        List<Pet> GetPetsOnSale();
         List<Pet> GetPetsOnSale(bool IsConatin, int UserId);
        
    }
}
