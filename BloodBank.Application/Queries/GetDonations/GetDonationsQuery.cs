using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetDonations
{
    public  class GetDonationsQuery : IRequest<ResultViewModel<List<DonationViewModel>>>
    {
    }
}
