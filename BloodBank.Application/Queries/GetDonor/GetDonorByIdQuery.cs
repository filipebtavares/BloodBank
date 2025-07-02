using BloodBank.Application.Model;
using MediatR;

namespace BloodBank.Application.Queries.GetDonor
{
    public class GetDonorByIdQuery : IRequest<ResultViewModel<DonorViewModel>>
    {
        public int Id { get; set; }

        public GetDonorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
