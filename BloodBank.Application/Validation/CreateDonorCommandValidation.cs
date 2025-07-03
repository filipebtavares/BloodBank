using BloodBank.Application.Commands.InsertDonor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Validation
{
    public class CreateDonorCommandValidation : AbstractValidator<CreateDonorCommand>
    {
        public CreateDonorCommandValidation()
        {
            RuleFor(donor => donor.FullName)
                .NotNull().WithMessage("The name can't be null")
                .MaximumLength(65).WithMessage("The name cannot contain more than 65 characters. ");

            RuleFor(donor => donor.Email)
                .NotNull().WithMessage("The field is requirede")
                .EmailAddress().WithMessage("the email address must be valid ");

            RuleFor(donor => donor.BirthDate)
                .NotNull().WithMessage("The birth date can't be null")
                .LessThan(DateTime.Now).WithMessage("This date can't be in a future");

            RuleFor(donor => donor.Genre)
                .NotNull().WithMessage("The genre cannot be null");

            RuleFor(donor => donor.Weight)
                .NotNull().WithMessage("The field is requirede")
                .GreaterThan(50).WithMessage("You can only donate if you weigh at least 50 kilos ");

            RuleFor(donor => donor.BloodType)
                .NotNull().WithMessage("The field is requirede")
                .MaximumLength(3).WithMessage("Invalid Data");
        }
    }
}
