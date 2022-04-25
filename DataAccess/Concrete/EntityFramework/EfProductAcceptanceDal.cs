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
    public class EfProductAcceptanceDal : EfEntityRepositoryBase<ProductAcceptance, TechinalServiceContext>, IProductAcceptanceDal
    {
        public List<ProductAcceptanceDetailDto> GetProductAcceptanceDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from p in context.ProductAcceptances
                             join c in context.Customers
                             on p.CustomerId equals c.CustomerId
                             join e in context.Employees
                             on p.EmployeeId equals e.EmployeeId
                             select new ProductAcceptanceDetailDto
                             {
                                 ProductAcceptanceId = p.ProductAcceptanceId,
                                 ArrivalDate = p.ArrivalDate,
                                 LeftDate = p.LeftDate,
                                 ProductSeriesNumber = p.ProductSeriesNumber,
                                 CustomerFullName = c.FirstName+" "+c.LastName,
                                 EmployeeFullName = e.FirstName+" "+e.LastName
                             };
                return result.ToList();

            }
        }
    }
}
