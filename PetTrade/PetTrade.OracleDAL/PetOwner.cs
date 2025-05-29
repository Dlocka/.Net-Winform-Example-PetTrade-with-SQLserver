using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrade.IDAL;
using PetTrade.Models;

namespace PetTrade.OracleDAL
{
    class PetOwner : IPetOwner
    {
        public object AddPet(int PetType, int PossessorId,float Price)
        {
            throw new NotImplementedException();
        }

        public object PetBuy(int PetId, int BuyerId )
        {
            throw new NotImplementedException();
        }

        object IPetOwner.AddPet(int PetType, int PossessorId, float price)
        {
            throw new NotImplementedException();
        }

        List<Pet> IPetOwner.GetPets(int PetPossessor)
        {
            throw new NotImplementedException();
        }

        List<Pet> IPetOwner.GetPetsOnSale()
        {
            throw new NotImplementedException();
        }

        List<Pet> IPetOwner.GetPetsOnSale(bool IsConatin, int UserId)
        {
            throw new NotImplementedException();
        }

        object IPetOwner.PetBuy(int PetId, int BuyerId)
        {
            throw new NotImplementedException();
        }
    }
}
