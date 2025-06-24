
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public class CreateBloofStockInputModel
    {
        public string BloodType { get;   set; }
        public string RhFactor { get;   set; }
        public int QuantityML { get;   set; }
    }
}
