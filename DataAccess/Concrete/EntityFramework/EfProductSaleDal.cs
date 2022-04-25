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
    public class EfProductSaleDal : EfEntityRepositoryBase<ProductSale, TechinalServiceContext>, IProductSaleDal
    {
        public List<ProductSalesDetailDto> ProductSalesDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from ps in context.ProductSales
                             join p in context.Products
                             on ps.ProductId equals p.ProductId
                             join c in context.Customers
                             on ps.CustomerId equals c.CustomerId
                             join e in context.Employees
                             on ps.EmployeeId equals e.EmployeeId
                             select new ProductSalesDetailDto
                             {
                                 ProductSaleId = ps.ProductSaleId,
                                 Price = ps.Price,
                                 ProductSeriesNumber = ps.ProductSeriesNumber,
                                 SalesDate = ps.SalesDate,
                                 Unit = ps.Unit,
                                 ProductName = p.ProductName,
                                 CustomerFullName = c.FirstName + " " + c.LastName,
                                 EmployeeFullName = e.FirstName +" "+e.LastName
                             };

                return result.ToList();
            }
        }
    }
}
