using BloodBank.Core.Entities;
using BloodBank.Core.Respositories;
using BloodBank.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace BloodBank.infrastructure.Repositories
{
    public class BloodStockRepository : IBloodStockRepository
    {

        private readonly BloodBankDbContext _context;

        public BloodStockRepository(BloodBankDbContext context)
        {
            _context = context;
        }

        public async Task<bool> BloodStockExists(int id)
        {
            return await _context.BloodStocks.AnyAsync(p => p.Id == id);
        }

        public async Task<BloodStock> GetBloodStockById(int id)
        {
            return await _context.BloodStocks.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> PostBloodStock(BloodStock bloodStock)
        {
            await _context.BloodStocks.AddAsync(bloodStock);
            await _context.SaveChangesAsync();

            return bloodStock.Id;
        }

        public async Task UpdateBloodStock(BloodStock bloodStock)
        {
             _context.BloodStocks.Update(bloodStock);
            await _context.SaveChangesAsync();
        }
    }
}
