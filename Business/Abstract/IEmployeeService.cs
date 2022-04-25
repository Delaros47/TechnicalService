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
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> Get(int employeeId);
        IDataResult<List<EmployeesDetailDto>> GetEmployeesDetailDto();
        IDataResult<List<EmployeesFullNameDto>> GetEmployeesFullNameDto();
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);
    }
}
