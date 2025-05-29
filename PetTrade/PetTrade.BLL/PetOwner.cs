using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrade.IDAL;
using PetTrade.Models;
namespace PetTrade.BLL
{
    public class PetOwner : IPetOwner
    {
        private readonly IPetOwner iPetOwner = UserFactory.CreatePetOwnerService();

        public object PetBuy(int PetId, int BuyerId)
        {
            return iPetOwner.PetBuy(PetId, BuyerId);
        }
        public object AddPet(int PetType, int PossessorId, float Price)
        {
            return iPetOwner.AddPet(PetType, PossessorId, Price);
        }

        public List<Pet> GetPets(int PetPossessor)
        {
            return iPetOwner.GetPets(PetPossessor);
        }

        public List<Pet> GetPetsOnSale()
        {
            return iPetOwner.GetPetsOnSale();
        }

        public List<Pet> GetPetsOnSale(bool IsConatin, int UserId)
        {
            return iPetOwner.GetPetsOnSale(IsConatin, UserId);
        }
    }
}
