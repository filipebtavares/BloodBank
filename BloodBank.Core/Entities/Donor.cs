using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Entities
{
    public class Donor
    {
        public int Id { get; private set; }
        public string  FullName { get; private set; }
        public string  Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Genre { get; private set; }
        public double Weight { get; private set; }
        public string  BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public List<Donations> Donations { get; private set; }
        public Address Address { get; private set; }

        public Donor()
        {
        }

        public Donor(int id, string fullName, string email, DateTime birthDate, string genre, 
            double weight, string bloodType, string rhFactor,  Address address)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Genre = genre;
            Weight = weight;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Address = address;

            Donations = [];
        }
    }
}
