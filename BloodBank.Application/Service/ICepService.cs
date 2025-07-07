using BloodBank.Application.Model;
 

namespace BloodBank.Application.Service
{
    public  interface ICepService
    {
        Task<ViaCepViewModel> GetAddressByCepAsync(string cep);
    }
}
