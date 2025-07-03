using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;

namespace BloodBank.Application.Queries.GetDonor
{
    public class GetDonorHandler : IRequestHandler<GetDonorQuery, ResultViewModel<List<DonorItemViewModel>>>
    {
        private readonly IDonorRespository _repository;

        public GetDonorHandler(IDonorRespository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<DonorItemViewModel>>> Handle(GetDonorQuery request, CancellationToken cancellationToken)
        {
            var donor = await _repository.GetDonors();
            var model = donor.Select(DonorItemViewModel.FromEntity).ToList();

            return ResultViewModel<List<DonorItemViewModel>>.Sucess(model);

        }
    }
}
