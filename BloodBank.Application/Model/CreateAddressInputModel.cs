using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Core.Entities;

namespace BloodBank.Application.Model
{
    public class CreateAddressInputModel
    {
        public string PublicPlace { get;   set; }
        public string City { get;   set; }
        public string State { get;   set; }
        public int CEP { get;   set; }

        public Address ToEntity()
            => new(PublicPlace, City, State, CEP);
    }
}
