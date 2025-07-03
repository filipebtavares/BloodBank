using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public  class DonorViewModel
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Genre { get; private set; }
        public string BloodType { get; private set; }
        public Address Address { get; private  set; }

        public DonorViewModel(string fullName, string email, DateTime birthDate,
            string genre, string bloodType, Address address)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Genre = genre;
            BloodType = bloodType;
            Address = address;
        }

        public static DonorViewModel FromEntity(Donor entity)
            => new(entity.FullName, entity.Email, entity.BirthDate, entity.Genre,
                entity.BloodType, entity.Address);
    }
}
