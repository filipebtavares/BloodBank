using BloodBank.Application.Commands.InsertBloodStock;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Validation
{
    public class CreateBloodStockCommandValidation : AbstractValidator<CreateBloodStockCommand>
    {
        public CreateBloodStockCommandValidation()
        {
            RuleFor(b => b.RhFactor)
                .MaximumLength(3).WithMessage("The Rhfactor is ivalid")
                .NotNull().WithMessage("The RhFactor cannot be null");

            RuleFor(t => t.BloodType)
                .NotNull().WithMessage("The Blood type cannot be null")
                .MaximumLength(2).WithMessage("The Blood type is invalid");

        }
    }
}
