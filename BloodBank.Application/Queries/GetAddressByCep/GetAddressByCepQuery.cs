using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetAddressByCep
{
    public  class GetAddressByCepQuery : IRequest<ResultViewModel<ViaCepViewModel>>
    {
        public string Cep { get; set; }

        public GetAddressByCepQuery(string cep)
        {
            Cep = cep;
        }
    }
}
