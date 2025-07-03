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

        public async Task<ViaCepViewModel> GetAddressByCepAsync(string cep)
        {
            var request = new RestRequest($"{cep}/json/", Method.Get);
            var response = await _client.ExecuteAsync<ViaCepViewModel>(request);

            if (!response.IsSuccessful || response.Data == null)
                throw new Exception("Erro ao consultar o ViaCEP.");

            return response.Data;
        }
    }
}
