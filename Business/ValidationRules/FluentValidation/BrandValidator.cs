using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {

        public BrandValidator()
        {
            RuleFor(b=>b.BrandName).NotEmpty().WithMessage("Brand Name cannot be empty");
            RuleFor(b=>b.BrandDescription).NotEmpty().WithMessage("Brand Description cannot be empty");
            RuleFor(b => b.BrandDescription).MinimumLength(100).WithMessage("Brand Description should be more than 100 letters length");
            RuleFor(b=>b.BrandDescription).MaximumLength(1000).WithMessage("Brand Description should be less than 1000 letters length");
        }
    }
}
