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
            RuleFor(donation => donation.QuantityMl)
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(450)
                .WithMessage("The donation cannot be less than 1ml nor greater than 450ml.");
        }
    }
}
