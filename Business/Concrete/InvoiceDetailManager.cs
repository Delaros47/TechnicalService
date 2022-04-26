using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class InvoiceDetailManager:IInvoiceDetailService
    {

        private readonly IInvoiceDetailDal _invoiceDetailDal;
        public InvoiceDetailManager(IInvoiceDetailDal invoiceDetailDal)
        {
            _invoiceDetailDal = invoiceDetailDal;
        }

        public IDataResult<List<InvoiceDetail>> GetAll()
        {
            return new SuccessDataResult<List<InvoiceDetail>>(_invoiceDetailDal.GetAll());
        }

        public IDataResult<InvoiceDetail> Get(int invoiceDetailId)
        {
            return new SuccessDataResult<InvoiceDetail>(
                _invoiceDetailDal.Get(i => i.InvoiceDetailId == invoiceDetailId));
        }

        public IDataResult<List<InvoiceDetailDto>> GetInvoiceDetailDto()
        {
            return new SuccessDataResult<List<InvoiceDetailDto>>(_invoiceDetailDal.GetInvoiceDetailDto());
        }

        public IResult Add(InvoiceDetail invoiceDetail)
        {
            ValidationTool.Validate(new InvoiceDetailValidator(),invoiceDetail);
            _invoiceDetailDal.Add(invoiceDetail);
            return new SuccessResult(Messages.GetMessage("Invoice Detail", Proccess.Add));
        }

        public IResult Update(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Update(invoiceDetail);
            return new SuccessResult(Messages.GetMessage("Invoice Detail", Proccess.Update));
        }

        public IResult Delete(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Delete(invoiceDetail);
            return new SuccessResult(Messages.GetMessage("Invoice Detail", Proccess.Delete));
        }
    }
}
