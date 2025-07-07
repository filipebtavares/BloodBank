

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
        public List<Donation> Donations { get; private set; }
        public Address Address { get; private set; }
        public bool  IsDeleted { get; private set; }


        public Donor()
        {
            
        }
        public Donor(int id, string fullName, string email, DateTime birthDate, string genre, 
            double weight, string bloodType, Address address)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Genre = genre;
            Weight = weight;
            BloodType = bloodType;
            Address = address;
            Donations = [];
        }

        public Donor(string fullName, string genre, string email, DateTime birthDate, 
            string bloodType, double weight, string rhFactor, Address address)
        {
            FullName = fullName;
            Genre = genre;
            Email = email;
            BirthDate = birthDate;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Weight = weight;
            IsDeleted = false;
            Address = address;
        }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }

        public void Update(string fullName, string genre, double weight, string email)
        {
            FullName = fullName;
            Genre = genre;
            Weight = weight;
            Email = email;
        }
    }
}
