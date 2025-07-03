using BloodBank.Application.Model;
using BloodBank.Application.Service;
using BloodBank.Core.Entities;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.InsertAddress
{
    public class CreateAddressHandler : IRequestHandler<CreateAddressCommand, ResultViewModel<int>>
    {
        private readonly IAddressRepository _repository;
        private readonly ICepService _viaCepService;

        public CreateAddressHandler(IAddressRepository repository, ICepService viaCepService)
        {
            _repository = repository;
            _viaCepService = viaCepService;
        }
        public async Task<ResultViewModel<int>> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var viaCepData = await _viaCepService.GetCep(request.Cep);

            var address = new Address(
                publicPlace: viaCepData.PublicPlace,
                city: viaCepData.Locality,
                state: viaCepData.Uf,
                cep: viaCepData.Cep
            );

            await _repository.PostAddress(address);

            return ResultViewModel<int>.Sucess(address.Id);
        }
    }
}
