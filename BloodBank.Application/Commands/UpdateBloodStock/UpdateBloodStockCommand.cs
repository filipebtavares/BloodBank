using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.UpdateBloodStock
{
    public  class UpdateBloodStockCommand : IRequest<ResultViewModel>
    {
        public int IdBloodStock { get; set; }
        public string BloodType  { get; set; }
        public int QuantityML { get; set; }
    }
}
