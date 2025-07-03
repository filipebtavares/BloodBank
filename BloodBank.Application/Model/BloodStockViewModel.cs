using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public class BloodStockViewModel
    {
        public string BloodType { get; private set; }
        public int QuantityML { get; private set; }

        public BloodStockViewModel(string bloodType, int quantityML)
        {
            BloodType = bloodType;
            QuantityML = quantityML;
        }

        public static BloodStockViewModel FromEntity(BloodStock entity)
            => new(entity.BloodType, entity.QuantityML);
    }
}
