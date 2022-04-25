using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInvoiceInfoDal : EfEntityRepositoryBase<InvoiceInfo, TechinalServiceContext>, IInvoiceInfoDal
    {
        public List<InvoiceInfosDetailDto> GetInvoiceInfosDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from i in context.InvoiceInfos
                             join c in context.Customers
                                 on i.CustomerId equals c.CustomerId
                             join e in context.Employees
                                 on i.EmployeeId equals e.EmployeeId
                             select new InvoiceInfosDetailDto()
                             {
                                 InvoiceInfoId = i.InvoiceInfoId,
                                 InvoiceDate = i.InvoiceDate,
                                 InvoiceOrderNumber = i.InvoiceOrderNumber,
                                 InvoiceSerialNumber = i.InvoiceSerialNumber,
                                 TaxOffice = i.TaxOffice,
                                 CustomerFullName = c.FirstName+" "+c.LastName,
                                 EmployeeFullName = e.FirstName+" "+e.LastName
                             };
                return result.ToList();
            }
        }
    }
}
