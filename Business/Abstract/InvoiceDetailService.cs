using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IInvoiceDetailService
    {
        IDataResult<List<InvoiceDetail>> GetAll();
        IDataResult<InvoiceDetail> Get(int invoiceDetailId);
        IDataResult<List<InvoiceDetailDto>> GetInvoiceDetailDto();
        IResult Add(InvoiceDetail invoiceDetail);
        IResult Update(InvoiceDetail invoiceDetail);
        IResult Delete(InvoiceDetail invoiceDetail);
    }
}
