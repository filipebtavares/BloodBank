using BloodBank.Application.Model;
using MediatR;


namespace BloodBank.Application.Queries.GetAddress
{
    public  class GetAddressQuery : IRequest<ResultViewModel<List<AddressViewModel>>>
    {
    }
}
