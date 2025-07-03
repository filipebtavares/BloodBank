using BloodBank.Core.Entities;
using BloodBank.Core.Enums;


namespace BloodBank.Application.Model
{
    public class DonationViewModel
    {
        public int QuantityMl { get; private set; }
        public DateTime DonationDate { get; private set; }
        public DonationsStatus Status { get; private set; }

        public DonationViewModel(int quantityMl, DateTime donationDate, DonationsStatus status)
        {
            QuantityMl = quantityMl;
            DonationDate = donationDate;
            Status = status;
        }

        public static DonationViewModel FromEntity(Donation entity)
            => new(entity.QuantityMl, entity.DonationDate, entity.Status);
    }
}
