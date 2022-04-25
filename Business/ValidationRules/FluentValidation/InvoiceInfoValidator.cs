using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class InvoiceInfoValidator:AbstractValidator<InvoiceInfo>
    {

        public InvoiceInfoValidator()
        {
            RuleFor(i=>i.CustomerId).NotEmpty().WithMessage("Customer name cannot be empty");
            RuleFor(i => i.EmployeeId).NotEmpty().WithMessage("Employee name cannot be empty");
            RuleFor(i => i.InvoiceDate).NotEmpty().WithMessage("Invoice date cannot be empty");
            RuleFor(i => i.InvoiceOrderNumber).NotEmpty().WithMessage("Invoice Order Number cannot be empty");
            RuleFor(i => i.InvoiceSerialNumber).NotEmpty().WithMessage("Invoice Serial Number cannot be empty");
            RuleFor(i => i.TaxOffice).NotEmpty().WithMessage("Tax Office cannot be empty");
        }

    }
}
