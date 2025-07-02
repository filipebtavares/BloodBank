using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Core.Enums;

namespace BloodBank.Core.Entities
{
    public  class Donation
    {
        public int IdDonor { get; private set; }
        public int Id { get; private set; }
        public DateTime DonorDate { get; private set; }
        public DateTime DonorFinishDate { get; private set; }
        public int QuantityMl { get; private set; }
        public Donor Donor { get; private set; }
        public List<BloodStock> BloodStocks { get; private set; }
        public DonationsStatus Status { get; private set; }
        public bool  IsDeleted { get; private set; }

        public Donation(int quantityMl)
        {
            QuantityMl = quantityMl;
            IsDeleted = false;
        }

        public Donation(int idDonor, int id, DateTime donorDate, int quantityMl, 
             DonationsStatus status, DateTime donorFinishDate, Donor donor)
        {
            IdDonor = IdDonor;
            Id = id;
            DonorDate = donorDate;
            QuantityMl = quantityMl;
            Status = DonationsStatus.Initial;
            DonorFinishDate = donorFinishDate;
            Donor = donor;

            BloodStocks = [];
           
        }

        public void InitialDonation()
        {
            if (Status == DonationsStatus.Initial)
            {
                Status = DonationsStatus.Initial;
                DonorDate = DateTime.Now;
            }
        }

        public void FinishDonation()
        {
            if (Status == DonationsStatus.Finished)
            {
                Status = DonationsStatus.Finished;
                DonorFinishDate = DateTime.Now;
            }
        }

        public void SetAsDeleted()
        {
            Status = DonationsStatus.Deleted;
        }
    }
}
