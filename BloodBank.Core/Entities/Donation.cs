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
        public DateTime DonationDate { get; private set; }
        public DateTime DonationFinishDate { get; private set; }
        public DateTime  DonationsDeleteDate { get; private set; }
        public int QuantityMl { get; private set; }
        public Donor Donor { get; private set; }
        public BloodStock BloodStock { get; private set; }
        public int IdBloodStock { get; private set; }
        public DonationsStatus Status { get; private set; }
        public bool  IsDeleted { get; private set; }

        public Donation(int quantityMl, int idBloodStock, int idDonor)
        {
            IdDonor = idDonor;
            QuantityMl = quantityMl;
            IdBloodStock = idBloodStock;
            Status = DonationsStatus.Initial;
            DonationDate = DateTime.Now;
            IsDeleted = false;
        }

        public Donation(int idDonor, int id, DateTime donorDate, int quantityMl, 
             DonationsStatus status, DateTime donorFinishDate, Donor donor, DateTime donationDeleteDate, int idBloodStock)
        {
            IdDonor = IdDonor;
            Id = id;
            DonationDate = donorDate;
            QuantityMl = quantityMl;
            Status = DonationsStatus.Initial;
            DonationFinishDate = donorFinishDate;
            Donor = donor;
            DonationsDeleteDate = donationDeleteDate;
            IdBloodStock = idBloodStock;
           
        }


        public void DonationEstate()
        {
            if (Status == DonationsStatus.Initial)
            {
                Status = DonationsStatus.Initial;
                DonationDate = DateTime.Now;
            }else if(Status == DonationsStatus.Finished)
            {
                Status = DonationsStatus.Finished;
                DonationFinishDate = DateTime.Now;
            }
            else
            {
                Status = DonationsStatus.Deleted;
                DonationsDeleteDate = DateTime.Now;
            }
        }

        public void SetAsDeleted()
        {
            Status = DonationsStatus.Deleted;
        }
    }
}
