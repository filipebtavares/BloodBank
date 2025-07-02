using BloodBank.Core.Entities;


namespace BloodBank.Core.Respositories
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAddress();
        Task<Address> GetAddressByCep(string cep);
        Task<int> PostAddress(Address address);
        Task<bool> AddressExists(int id);
        Task<Address> GetAddressById(int id);
        Task UpdatAddress(Address updateAddress);
    }
}
