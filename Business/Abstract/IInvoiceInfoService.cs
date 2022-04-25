using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IInvoiceInfoService
    {
        IDataResult<List<InvoiceInfo>> GetAll();
        IDataResult<InvoiceInfo> Get(int invoiceInfoId);
        IDataResult<List<InvoiceInfosDetailDto>> GetInvoiceInfosDetailDto();
        IResult Add(InvoiceInfo invoiceInfo);
        IResult Update(InvoiceInfo invoiceInfo);
        IResult Delete(InvoiceInfo invoiceInfo);
    }
}
