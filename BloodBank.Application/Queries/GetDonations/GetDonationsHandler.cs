using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetDonations
{
    public class GetDonationsHandler : IRequestHandler<GetDonationsQuery, ResultViewModel<List<DonationViewModel>>>
    {
        private readonly IDonationRepository _repository;

        public GetDonationsHandler(IDonationRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<DonationViewModel>>> Handle(GetDonationsQuery request, CancellationToken cancellationToken)
        {
            var donation = await _repository.GetDonation();

            var model = donation.Select(DonationViewModel.FromEntity).ToList();

            return ResultViewModel<List<DonationViewModel>>.Sucess(model);
        }
    }
}
