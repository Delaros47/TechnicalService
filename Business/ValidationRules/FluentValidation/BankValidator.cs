using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BankValidator:AbstractValidator<Bank>
    {

        public BankValidator()
        {
            RuleFor(b=>b.BankName).NotEmpty().WithMessage("Bank Name cannot be empty");
            RuleFor(b=>b.BankDescription).NotEmpty().WithMessage("Bank Description cannot be empty");
            RuleFor(b=>b.BankDescription).MaximumLength(500).WithMessage("Bank Description cannot be less than 500 letter length");
        }
    }
}
