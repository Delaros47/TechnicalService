using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {

        public EmployeeValidator()
        {
            RuleFor(e=>e.FirstName).NotEmpty().WithMessage("First name cannot be empty");
            RuleFor(e => e.LastName).NotEmpty().WithMessage("Last name cannot be empty");
            RuleFor(e => e.IdentityNumber).NotEmpty().WithMessage("Identity number cannot be empty");
            RuleFor(e => e.Phone).NotEmpty().WithMessage("Phone number cannot be empty");
            RuleFor(e => e.Address).NotEmpty().WithMessage("Address cannot be empty");
            RuleFor(e => e.DateOfBirth).NotEmpty().WithMessage("Date of birth cannot be empty");
            RuleFor(e => e.DepartmentId).NotEmpty().WithMessage("Department name cannot be empty");
            RuleFor(e => e.Email).NotEmpty().WithMessage("Email address cannot be empty");
            RuleFor(e => e.Picture).NotEmpty().WithMessage("Employee picture cannot be empty");
        }

    }
}
