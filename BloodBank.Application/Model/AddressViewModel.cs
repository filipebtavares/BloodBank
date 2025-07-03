using BloodBank.Core.Entities;
 

namespace BloodBank.Application.Model
{
    public  class AddressViewModel
    {
        public string PublicPlace { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public AddressViewModel(string publicPlace, string city, string state)
        {
            PublicPlace = publicPlace;
            City = city;
            State = state;
        }

        public static AddressViewModel FromEntity(Address entity)
            => new(entity.PublicPlace, entity.City, entity.State);
    }
}
