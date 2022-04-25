using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductAcceptanceValidator:AbstractValidator<ProductAcceptance>
    {

        public ProductAcceptanceValidator()
        {
            RuleFor(p=>p.EmployeeId).NotEmpty().WithMessage("Employee name cannot be empty");
            RuleFor(p => p.CustomerId).NotEmpty().WithMessage("Customer name cannot be empty");
            RuleFor(p => p.ProductSeriesNumber).NotEmpty().WithMessage("Product Series Number cannot be empty");
            RuleFor(p => p.ArrivalDate).NotEmpty().WithMessage("Arrival date cannot be empty");

        }
    }
}
