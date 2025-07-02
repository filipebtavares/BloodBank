using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.InsertDonation
{
    public class CreateDonationCommand : IRequest<ResultViewModel<int>>
    {
        public int QuantityMl { get; set; }


        public Donation ToEntity()
            => new(QuantityMl);
    }
}
