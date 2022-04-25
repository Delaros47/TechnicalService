using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductSaleValidator:AbstractValidator<ProductSale>
    {

        public ProductSaleValidator()
        {
            RuleFor(p=>p.Price).NotEmpty().WithMessage("Price cannot be empty");
            RuleFor(p => p.Unit).NotEmpty().WithMessage("Unit cannot be empty");
            RuleFor(p => p.SalesDate).NotEmpty().WithMessage("Sales Date cannot be empty");
            RuleFor(p => p.ProductSeriesNumber).NotEmpty().WithMessage("Product Series Number cannot be empty");
            RuleFor(p => p.CustomerId).NotEmpty().WithMessage("Customet name cannot be empty");
            RuleFor(p => p.EmployeeId).NotEmpty().WithMessage("Employee name cannot be empty");
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("Product name cannot be empty");
        }

    }
}
