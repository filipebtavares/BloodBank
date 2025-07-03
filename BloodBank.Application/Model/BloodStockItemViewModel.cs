using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public class BloodStockItemViewModel
    {
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int QuantityML { get; private set; }
       

        public BloodStockItemViewModel(string bloodType, string rhFactor, int quantityML)
        {
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityML = quantityML;

           
        }

        public static BloodStockItemViewModel FromEntity(BloodStock entity)
             => new(entity.BloodType, entity.RhFactor, entity.QuantityML);
    }
}
