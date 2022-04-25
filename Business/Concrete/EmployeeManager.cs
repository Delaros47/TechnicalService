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
    public class EmployeeManager : IEmployeeService
    {

        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<List<EmployeesFullNameDto>> GetEmployeesFullNameDto()
        {
            return new SuccessDataResult<List<EmployeesFullNameDto>>(_employeeDal.GetEmployeesFullNameDto());
        }

        public IResult Add(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(),employee);
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.GetMessage("Employee",Proccess.Add));
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.GetMessage("Employee", Proccess.Delete));
        }

        public IDataResult<Employee> Get(int employeeId)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e=>e.EmployeeId==employeeId));
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll());
        }

        public IDataResult<List<EmployeesDetailDto>> GetEmployeesDetailDto()
        {
            return new SuccessDataResult<List<EmployeesDetailDto>>(_employeeDal.GetEmployeesDetailDto());
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.GetMessage("Employee", Proccess.Update));
        }
    }
}
