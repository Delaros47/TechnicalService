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
    public class EfInvoiceDetailDal : EfEntityRepositoryBase<InvoiceDetail, TechinalServiceContext>, IInvoiceDetailDal
    {
        public List<InvoiceDetailDto> GetInvoiceDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from i in context.InvoiceDetails
                             join ii in context.InvoiceInfos
                                 on i.InvoiceInfoId equals ii.InvoiceInfoId
                             select new InvoiceDetailDto
                             {
                                 InvoiceDetailId = i.InvoiceDetailId,
                                 Price = i.Price,
                                 TotalPrice = i.TotalPrice,
                                 Unit = i.Unit,
                                 InvoiceInfoId = ii.InvoiceInfoId
                             };

                return result.ToList();

            }
        }
    }
}
