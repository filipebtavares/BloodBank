using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using BloodBank.Core.Respositories;
using MediatR;
 

namespace BloodBank.Application.Commands.InsertDonation
{
    public class CreateDonationHandler : IRequestHandler<CreateDonationCommand, ResultViewModel<int>>
    {

        private readonly IDonationRepository _repository;
        private readonly IDonorRespository _donorRepository;
        private readonly IBloodStockRepository _bloodStockRepository;


        public CreateDonationHandler(IDonationRepository repository, IDonorRespository donorRespository, 
            IBloodStockRepository bloodStockRepository)
        {
            _repository = repository;
            _donorRepository = donorRespository;
            _bloodStockRepository = bloodStockRepository;
        }
        public async Task<ResultViewModel<int>> Handle(CreateDonationCommand request, CancellationToken cancellationToken)
        {
            var donor = await _donorRepository.GetDonorById(request.IdDonor);
            if (donor == null)
                return ResultViewModel<int>.Error("Donor not found");
 
            var bloodStock = await _bloodStockRepository
                .GetByTypeAndRhAsync(donor.BloodType, donor.RhFactor);

            if (bloodStock == null)
                return ResultViewModel<int>.Error("Matching blood stock not found");

           
            bloodStock.Update(bloodStock.BloodType, bloodStock.QuantityML + request.QuantityMl);
            await _bloodStockRepository.UpdateBloodStock(bloodStock);

            bloodStock.AddDonation(request.QuantityMl);
            var donation = new Donation(request.IdDonor, request.QuantityMl, bloodStock.Id);
            await _repository.PostDonation(donation);

            return ResultViewModel<int>.Sucess(donation.Id);
        }
    }
}
