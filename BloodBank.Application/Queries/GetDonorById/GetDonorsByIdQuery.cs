using BloodBank.Application.Model;
using MediatR;


namespace BloodBank.Application.Queries.GetDonorById
{
    public  class GetDonorsByIdQuery : IRequest<ResultViewModel<DonorViewModel>>
    {
        public int Id { get; set; }

        public GetDonorsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
