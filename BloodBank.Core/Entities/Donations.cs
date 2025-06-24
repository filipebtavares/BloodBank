using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Core.Enums;

namespace BloodBank.Core.Entities
{
    public  class Donations
    {
        public int DonorId { get; private set; }
        public int Id { get; private set; }
        public DateTime DonorDate { get; private set; }
        public DateTime DonorFinishDate { get; private set; }
        public int QuantityML { get; private set; }
        public Donor Donor { get; private set; }
        public DonationsStatus Status { get; private set; }

        public Donations()
        {
        }

        public Donations(int donorId, int id, DateTime donorDate, int quantityML, 
            Donor donor, DonationsStatus status, DateTime donorFinishDate)
        {
            DonorId = donorId;
            Id = id;
            DonorDate = donorDate;
            QuantityML = quantityML;
            Donor = donor;
            Status = DonationsStatus.Initial;
            DonorFinishDate = donorFinishDate;
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
    }
}
