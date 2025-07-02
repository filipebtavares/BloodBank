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
    public class DonorRepository : IDonorRespository
    {
        private readonly BloodBankDbContext _context;

        public DonorRepository(BloodBankDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DonorExists(int id)
        {
            return await _context.Donors.AnyAsync(p => p.Id == id);
        }

        public async Task<Donor> GetDonorById(int id)
        {
            return await _context.Donors.SingleOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Donor>> GetDonors(string search)
        {
            var donors = await  _context.Donors
                .Include(p => p.Address)
                .Include(p => p.Donations)
                .ToListAsync();

            return donors;
        }

        public async Task<int> PostDonor(Donor donor)
        {
            await _context.Donors.AddAsync(donor);
           await  _context.SaveChangesAsync();

            return donor.Id;
        }

        public async Task UpdateDonor(Donor donor )
        {
             _context.Donors.Update(donor);
            await _context.SaveChangesAsync();
        }
    }
}
