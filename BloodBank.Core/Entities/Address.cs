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
        public string  District { get; private set; }
        public string Cep { get; private set; }
        public int IdDonor { get; private set; }
        public List<Donor> Donors { get; private set; }
        public bool IsDeleted { get; private set; }

        public Address(string publicPlace, string city, string cep,string state)
        {
            PublicPlace = publicPlace;
            City = city;
            Cep = cep;
            State = state;
            IsDeleted = false;
        }

        public Address(int id, string publicPlace, string city, string state, string cep, int idDonor, string district)
        {
            Id = id;
            PublicPlace = publicPlace;
            City = city;
            State = state;
            Cep = cep;
            IdDonor = idDonor;
            District = district;
            Donors = [];
        }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }

        public void Update(string publicPlace, string state, string city, string cep)
        {
            PublicPlace = publicPlace;
            State = state;
            City = city;
            Cep = cep;
        }
    }
}
