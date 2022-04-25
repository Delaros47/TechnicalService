using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.CrossCuttingCorcerns.Validation;
using Universal.Utilities.Abstract;
using Universal.Utilities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<CustomersFullNameDto>> GetCustomersFullNameDto()
        {
            return new SuccessDataResult<List<CustomersFullNameDto>>(_customerDal.GetCustomersFullNameDto());
        }

        public IResult Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(),customer);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }
        
        public IDataResult<Customer> Get(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.CustomerId==customerId));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<CustomerCityStatisticsDto>> GetCustomerCityStatisticsDto()
        {
            return new SuccessDataResult<List<CustomerCityStatisticsDto>>(_customerDal.GetCustomerCityStatisticsDto());
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetailDto()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto());
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
