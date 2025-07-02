using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
 

namespace BloodBank.Application.Commands.DeleteDonation
{
    public class DeleteDonationHandler : IRequestHandler<DeleteDonationCommand, ResultViewModel>
    {

        private readonly IDonationRepository _repository;

        public DeleteDonationHandler(IDonationRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(DeleteDonationCommand request, CancellationToken cancellationToken)
        {
            var donation = await _repository.GetDonationById(request.Id);

            if(donation is null)
            {
                return ResultViewModel.Error("this donation does not exist.");
            }

            donation.SetAsDeleted();

            await _repository.AsDeleted(donation);

            return ResultViewModel.Sucess();

        }
    }
}
