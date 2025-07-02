using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;

namespace BloodBank.Application.Commands.InsertDonor
{
    public class CreateDonorHandler : IRequestHandler<CreateDonorCommand, ResultViewModel<int>>
    {
        private readonly IDonorRespository _repository;

        public CreateDonorHandler(IDonorRespository respository)
        {
            _repository = _repository;
        }

        public async  Task<ResultViewModel<int>> Handle(CreateDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = request.ToEntity();

            await _repository.PostDonor(donor);

            return ResultViewModel<int>.Sucess(donor.Id);
        }
    }
}
