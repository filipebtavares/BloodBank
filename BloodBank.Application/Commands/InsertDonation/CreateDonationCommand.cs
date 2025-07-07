using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using MediatR;
 

namespace BloodBank.Application.Commands.InsertDonation
{
    public class CreateDonationCommand : IRequest<ResultViewModel<int>>
    {
        public int QuantityMl { get; set; }
        public int IdDonor { get; set; }


      
    }
}
