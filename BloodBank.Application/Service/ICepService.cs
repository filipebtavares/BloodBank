using BloodBank.Application.Model;
 

namespace BloodBank.Application.Service
{
    public  interface ICepService
    {
        Task<ViaCepViewModel> GetCep(string cep);
    }
}
