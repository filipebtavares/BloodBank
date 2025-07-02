using BloodBank.Core.Entities;
using BloodBank.Core.Respositories;
using BloodBank.infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly BloodBankDbContext _context;

        public AddressRepository(BloodBankDbContext context)
        {
            _context = context;
        }
        public async Task<List<Address>> GetAddress()
        {
            var address = await _context.Addresses
                .Include(p => p.Donors)
                .ToListAsync();

            return address;
        }

        public async Task<Address> GetAddressByCep(string cep)
        {
            return await _context.Addresses.FirstOrDefaultAsync(p => p.Cep == cep);
        }

        public async Task<int> PostAddress(Address address)
        {
            await _context.AddAsync(address);
            await _context.SaveChangesAsync();

            return address.Id;
        }

        public async Task UpdatAddress(Address updateAddress)
        {
             _context.Addresses.Update(updateAddress);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> AddressExists(int id)
        {
            return await _context.Addresses.AnyAsync(p => p.Id == id);
        }

        public async Task<Address> GetAddressById(int id)
        {
            return await _context.Addresses.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
