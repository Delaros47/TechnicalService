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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, TechinalServiceContext>, ICustomerDal
    {
        public List<CustomerCityStatisticsDto> GetCustomerCityStatisticsDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from c in context.Cities
                             join c1 in context.Customers
                             on c.CityId equals c1.CityId
                             orderby c.CityName ascending
                             group c.CityName by c.CityName into groupCity
                             select new CustomerCityStatisticsDto
                             {
                                 CityName = groupCity.Key,
                                 TotalCustomers = groupCity.Count()
                             };
                return result.ToList();
            }
        }

        public List<CustomersFullNameDto> GetCustomersFullNameDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from c in context.Customers
                    select new CustomersFullNameDto
                    {
                        CustomerId = c.CustomerId,
                        CustomerFullName = c.FirstName+" "+c.LastName
                    };
                return result.ToList();
            }
        }

        public List<CustomerDetailDto> GetCustomerDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from c in context.Customers
                             join b in context.Banks
                             on c.BankId equals b.BankId
                             join c2 in context.Cities
                             on c.CityId equals c2.CityId
                             select new CustomerDetailDto
                             {
                                CustomerId= c.CustomerId,
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                DateOfBirth = c.DateOfBirth,
                                Email = c.Email,
                                IdentityNumber = c.IdentityNumber,
                                Phone = c.Phone,
                                TaxNumber = c.TaxNumber,
                                TaxOffice = c.TaxOffice,
                                Title = c.Title,
                                CityName = c2.CityName,
                                BankName = b.BankName
                             };

                return result.ToList();        
            }
        }
    }
}
