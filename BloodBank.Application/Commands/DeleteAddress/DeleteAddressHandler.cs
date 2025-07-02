using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.DeleteAddress
{
    public class DeleteAddressHandler : IRequestHandler<DeleteAddressCommand, ResultViewModel>
    {
        private readonly IAddressRepository _repository;

        public DeleteAddressHandler(IAddressRepository repository)
        {
            _repository = repository;
        }
        public async  Task<ResultViewModel> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddressById(request.Id);

            if (address is null)
            {
                return ResultViewModel.Error("This Address does not exist.");
            }

            address.SetAsDeleted();
            await _repository.UpdatAddress(address);

            return ResultViewModel.Sucess();
        }
    }
}
