using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;

namespace BloodBank.Application.Queries.GetAddress
{
    public class GetAddressHandler : IRequestHandler<GetAddressQuery, ResultViewModel<List<AddressViewModel>>>
    {
        private readonly IAddressRepository _repository;

        public GetAddressHandler(IAddressRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<AddressViewModel>>> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddress();

            var model = address.Select(AddressViewModel.FromEntity).ToList();

            return ResultViewModel<List<AddressViewModel>>.Sucess(model);
        }
    }
}
