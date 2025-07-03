using BloodBank.Application.Model;
using BloodBank.Application.Service;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetAddressByCep
{
    public  class GetAddressByCepHandler : IRequestHandler<GetAddressByCepQuery, ResultViewModel<ViaCepViewModel>>
    {
        private readonly ICepService _service;

        public GetAddressByCepHandler(ICepService service)
        {
            _service = service;
        }

        public async Task<ResultViewModel<ViaCepViewModel>> Handle(GetAddressByCepQuery request, CancellationToken cancellationToken)
        {
            var viaCep = await _service.GetCep(request.Cep);

            if(viaCep is null)
            {
                return ResultViewModel<ViaCepViewModel>.Error("The cep does not exist");
            }

            return ResultViewModel<ViaCepViewModel>.Sucess(viaCep);
        }
    }
}
