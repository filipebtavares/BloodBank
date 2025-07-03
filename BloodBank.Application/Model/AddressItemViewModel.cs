using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public class AddressItemViewModel
    {
        public string PublicPlace { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Cep { get; private set; }
        public int IdDonor { get; private set; }

        public AddressItemViewModel(string publicPlace, string city, string state, string cep, int idDonor)
        {
            PublicPlace = publicPlace;
            City = city;
            State = state;
            Cep = cep;
            IdDonor = idDonor;
        }

        public static AddressItemViewModel FromEntity(Address entity)
            => new(entity.PublicPlace, entity.City, entity.State, entity.Cep, entity.IdDonor);
    }
}
