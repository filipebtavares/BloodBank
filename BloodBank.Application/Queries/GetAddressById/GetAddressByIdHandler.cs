using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetAddressById
{
    public class GetAddressByIdHandler : IRequestHandler<GetAddressByIdQuery, ResultViewModel<AddressItemViewModel>>
    {
        private readonly IAddressRepository _repository;

        public GetAddressByIdHandler(IAddressRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<AddressItemViewModel>> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddressById(request.Id);

            if(address is null)
            {
                return ResultViewModel<AddressItemViewModel>.Error("The address does not exist.");
            }

            var model = AddressItemViewModel.FromEntity(address);

            return ResultViewModel<AddressItemViewModel>.Sucess(model);
        }
    }
}
