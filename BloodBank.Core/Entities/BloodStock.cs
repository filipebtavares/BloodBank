using BloodBank.Core.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Entities
{
    public class BloodStock
    {
        public int Id { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int QuantityML { get; private set; }
        public int IdDonation { get; private set; }
        public Donation Donation { get; private set; }
        public bool  IsDeleted { get; private set; }



        public BloodStock(String bloodType, string rhFactor, int quantityML, int idDonation)
        {
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityML = quantityML;
            IdDonation = idDonation;
            IsDeleted = false;
        }


        public BloodStock(int id, string bloodType, string rhFactor, int quantityML, Donation donation, int idDonation)
        {
            Id = id;
            BloodType = bloodType;
            RhFactor = rhFactor;
            QuantityML = quantityML;
            IdDonation = idDonation;
            Donation = donation;
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
    }
}
