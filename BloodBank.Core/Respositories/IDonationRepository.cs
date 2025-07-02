using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Respositories
{
    public interface IDonationRepository
    {
        Task<List<Donation>> GetDonation();
        Task<Donation?> GetDonationById(int id);
        Task<int> PostDonation(Donation donation);
        Task AsDeleted(Donation donation);
    }
}
