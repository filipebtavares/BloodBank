

using BloodBank.Application.Model;
using MediatR;

namespace BloodBank.Application.Queries.GetAddressById
{
    public class GetAddressByIdQuery : IRequest<ResultViewModel<AddressItemViewModel>>
    {
        public int Id { get; set; }

        public GetAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
