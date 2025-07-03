
using BloodBank.Core.Entities;
using System.Text.Json.Serialization;
 

namespace BloodBank.Application.Model
{
    public  class ViaCepViewModel
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string PublicPlace { get; set; }

        [JsonPropertyName("bairro")]
        public string District { get; set; }

        [JsonPropertyName("localidade")]
        public string Locality { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }

       
    }
}
