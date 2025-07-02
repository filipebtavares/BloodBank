using BloodBank.Application.Model;
using BloodBank.Application.Service;
using RestSharp;

namespace BloodBank.infrastructure.ExternalService.ViaCep
{
    public class CepService : ICepService
    {
        private readonly RestClient _client;

        public CepService()
        {
            _client = new RestClient("https://viacep.com.br/ws/");
        }
        public async Task<AddressViewModel> GetCep(string cep)
        {
            var request = new RestRequest($"{cep}/json", Method.Get);
            var response = await _client.ExecuteAsync<AddressViewModel>(request);

            if (!response.IsSuccessful || response.Data == null)
                throw new Exception("Error to consult CEP");

            return response.Data;
        }
    }
}
