using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.Models
{
    public class User
    {
        public int UserId;
        public string UserName;
        public string Password;
        public int UserTypeId;
        public float AccountBanlance;
        public List<Pet> PetList { get; set; }
    }
}
