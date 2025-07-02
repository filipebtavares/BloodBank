using BloodBank.Application.Model;
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
        public async Task<ResultViewModel<int>> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = request.ToEntity();

            await _repository.PostAddress(address);

            return ResultViewModel<int>.Sucess(address.Id);
        }
    }
}
