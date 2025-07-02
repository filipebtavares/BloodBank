using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.UpdateAddress
{
    public  class UpdateAddressHandler : IRequestHandler<UpdateAddressCommand, ResultViewModel>
    {
        private readonly IAddressRepository _repository;

        public UpdateAddressHandler(IAddressRepository repository)
        {
            _repository = repository;
        }

        public async  Task<ResultViewModel> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddressById(request.IdAddress);

            if (address is null)
            {
                return ResultViewModel.Error("This Address does not exist");
            }

            address.Update(request.PublicPlace, request.State, request.City, request.Cep);
            await _repository.UpdatAddress(address);

            return ResultViewModel.Sucess();

        }
    }
}
