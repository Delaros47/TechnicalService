using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface ICustomerService
    {

        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetailDto();
        IDataResult<List<CustomerCityStatisticsDto>> GetCustomerCityStatisticsDto();
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);


    }
}
