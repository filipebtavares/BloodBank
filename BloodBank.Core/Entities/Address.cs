using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Entities
{
    public class Address
    {
        public int Id { get; private set; }
        public string PublicPlace { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public int CEP { get; private set; }
        public Donor Donor { get; private set; }

        public Address()
        {
        }

        public Address(int id, string publicPlace, string city, string state, int cEP, Donor donor)
        {
            Id = id;
            PublicPlace = publicPlace;
            City = city;
            State = state;
            CEP = cEP;
            Donor = donor;
        }
    }
}
