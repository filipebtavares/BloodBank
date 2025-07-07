

namespace BloodBank.Core.Entities
{
    public class BloodStock
    {
        public int Id { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int QuantityML { get; private set; }
        public ICollection<Donation> Donations { get; private set; } = new List<Donation>();
        public bool  IsDeleted { get; private set; }



        public BloodStock(String bloodType, string rhFactor  )
        {
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityML = 0;
            IsDeleted = false;
        }


        public BloodStock(int id, string bloodType, string rhFactor, int quantityML)
        {
            Id = id;
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityML = quantityML;
        }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }

        public void Update(string bloodType, int quantityMl)
        {
            BloodType = bloodType;

            QuantityML = quantityMl;
        }

        public void AddDonation(int quantityMl)
        {
            QuantityML += quantityMl;
        }
    }
}
