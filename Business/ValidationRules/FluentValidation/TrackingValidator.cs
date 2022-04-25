using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TrackingValidator:AbstractValidator<Tracking>
    {
        public TrackingValidator()
        {
            RuleFor(t => t.ProductSeriesNumber).NotEmpty().WithMessage("Product Series Number cannot be empty");
            RuleFor(t => t.Date).NotEmpty().WithMessage("Tracking Date cannot be empty");
            RuleFor(t => t.Description).NotEmpty().WithMessage("Tracking Description cannot be empty");
        }
    }
}
