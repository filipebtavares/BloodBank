using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Entities
{
    public class BloodStock
    {
        public int Id { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int QuantityML { get; private set; }

        public BloodStock()
        {
        }

        public BloodStock(int id, string bloodType, string rhFactor, int quantityML)
        {
            Id = id;
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityML = quantityML;
        }
    }
}
