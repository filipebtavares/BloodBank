using BloodBank.Core.Entities;
using BloodBank.Core.Respositories;
using BloodBank.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.infrastructure.Repositories
{
    public class DonationRepository : IDonationRepository
    {

        private readonly BloodBankDbContext _context;

        public DonationRepository(BloodBankDbContext context)
        {
            _context = context;
        }

        public async Task AsDeleted(Donation donation)
        {
            _context.Donations.Update(donation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Donation>> GetDonation()
        {
            var donation = await _context.Donations
                .Include(p => p.Donor)
                .Include(p => p.BloodStocks)
                .ToListAsync();

            return donation;
        }

        public async Task<Donation?> GetDonationById(int id)
        {
            return await _context.Donations.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> PostDonation(Donation donation)
        {
            await _context.Donations.AddAsync(donation);
            await _context.SaveChangesAsync();

            return donation.Id;
        }
    }
}
