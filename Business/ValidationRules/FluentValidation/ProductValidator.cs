using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().WithMessage("Product Name cannot be empty");
            RuleFor(p=>p.BrandId).NotEmpty().WithMessage("Brand Name cannot be empty");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category Name cannot be empty");
            RuleFor(p => p.PurchasePrice).NotEmpty().WithMessage("Purchase Price cannot be empty");
            RuleFor(p => p.SalePrice).NotEmpty().WithMessage("Sale Price cannot be empty");
            RuleFor(p => p.State).NotEmpty().WithMessage("State either false or true");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Units In Stock cannot be empty");
        }

    }
}
