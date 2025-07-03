using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetDonor
{
    public  class GetDonorQuery : IRequest<ResultViewModel<List<DonorItemViewModel>>>
    {
    }
}
