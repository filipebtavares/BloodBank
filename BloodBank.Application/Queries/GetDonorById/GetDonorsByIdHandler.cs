using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;


namespace BloodBank.Application.Queries.GetDonorById
{
    public class GetDonorsByIdHandler : IRequestHandler<GetDonorsByIdQuery, ResultViewModel<DonorViewModel>>
    {
        private readonly IDonorRespository _repository;


        public GetDonorsByIdHandler(IDonorRespository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<DonorViewModel>> Handle(GetDonorsByIdQuery request, CancellationToken cancellation)
        {
            var donors = await _repository.GetDonorById(request.Id);

            if (donors is null)
            {
                return ResultViewModel<DonorViewModel>.Error("This Donor does not exist.");
            }

            var model = DonorViewModel.FromEntity(donors);
            return ResultViewModel<DonorViewModel>.Sucess(model);
        }
    }
}
