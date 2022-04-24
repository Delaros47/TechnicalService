using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.FirstName).NotEmpty().WithMessage("First name cannot be empty");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Last name cannot be empty");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("Identity number cannot be empty");
            RuleFor(c => c.Phone).NotEmpty().WithMessage("Phone number cannot be empty");
            RuleFor(c => c.TaxNumber).NotEmpty().WithMessage("Tax Number cannot be empty");
            RuleFor(c => c.TaxOffice).NotEmpty().WithMessage("Tax Office cannot be empty");
            RuleFor(c => c.Title).NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(c => c.DateOfBirth).NotEmpty().WithMessage("Date Of Birth cannot be empty");
            RuleFor(c => c.Email).NotEmpty().WithMessage("Email name cannot be empty");
            RuleFor(c => c.CityId).NotEmpty().WithMessage("City name cannot be empty");
            RuleFor(c => c.BankId).NotEmpty().WithMessage("Bank name cannot be empty");
        }

    }
}
