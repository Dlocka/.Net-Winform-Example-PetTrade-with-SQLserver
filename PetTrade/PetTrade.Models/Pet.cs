using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int PetType { get; set; }
        public int PetPossessor { get; set; }
        public int SaleStatus { get; set; }
        public int Price { get; set; }

    }
}
