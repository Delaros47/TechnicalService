using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class InvoiceDetailValidator:AbstractValidator<InvoiceDetail>
    {

        public InvoiceDetailValidator()
        {
            RuleFor(i=>i.InvoiceInfoId).NotEmpty().WithMessage("Invoice Id cannot be empty");
            RuleFor(i => i.Price).NotEmpty().WithMessage("Price cannot be empty");
            RuleFor(i => i.TotalPrice).NotEmpty().WithMessage("Total price cannot be empty");
            RuleFor(i => i.Unit).NotEmpty().WithMessage("Unit cannot be empty");
            RuleFor(i => i.ProductId).NotEmpty().WithMessage("Product name cannot be empty");
        }

    }
}
