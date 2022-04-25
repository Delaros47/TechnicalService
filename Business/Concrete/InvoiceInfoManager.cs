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
    public class InvoiceInfoManager:IInvoiceInfoService
    {

        private readonly IInvoiceInfoDal _invoiceInfoDal;
        public InvoiceInfoManager(IInvoiceInfoDal invoiceInfoDal)
        {
            _invoiceInfoDal = invoiceInfoDal;
        }

        public IDataResult<List<InvoiceInfo>> GetAll()
        {
            return new SuccessDataResult<List<InvoiceInfo>>(_invoiceInfoDal.GetAll());
        }

        public IDataResult<InvoiceInfo> Get(int invoiceInfoId)
        {
            return new SuccessDataResult<InvoiceInfo>(_invoiceInfoDal.Get(i => i.InvoiceInfoId == invoiceInfoId));
        }

        public IDataResult<List<InvoiceInfosDetailDto>> GetInvoiceInfosDetailDto()
        {
            return new SuccessDataResult<List<InvoiceInfosDetailDto>>(_invoiceInfoDal.GetInvoiceInfosDetailDto());
        }

        public IResult Add(InvoiceInfo invoiceInfo)
        {
            ValidationTool.Validate(new InvoiceInfoValidator(),invoiceInfo);
            _invoiceInfoDal.Add(invoiceInfo);
            return new SuccessResult(Messages.GetMessage("Invoice Info", Proccess.Add));
        }

        public IResult Update(InvoiceInfo invoiceInfo)
        {
            _invoiceInfoDal.Update(invoiceInfo);
            return new SuccessResult(Messages.GetMessage("Invoice Info", Proccess.Update));
        }

        public IResult Delete(InvoiceInfo invoiceInfo)
        {
            _invoiceInfoDal.Delete(invoiceInfo);
            return new SuccessResult(Messages.GetMessage("Invoice Info", Proccess.Delete));
        }
    }
}
