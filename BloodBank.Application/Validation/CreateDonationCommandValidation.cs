using BloodBank.Application.Commands.InsertDonation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Validation
{
    public  class CreateDonationCommandValidation : AbstractValidator<CreateDonationCommand>
    {
        public CreateDonationCommandValidation()
        {
            
        }
    }
}
