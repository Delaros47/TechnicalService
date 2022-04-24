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
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, TechinalServiceContext>, IEmployeeDal
    {
        public List<EmployeesDetailDto> GetEmployeesDetailDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from e in context.Employees
                             join d in context.Departments
                             on e.DepartmentId equals d.DepartmentId
                             select new EmployeesDetailDto
                             {
                                 EmployeeId = e.EmployeeId,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName,
                                 Email = e.Email,
                                 Phone = e.Phone,
                                 Address = e.Address,
                                 DateOfBirth = e.DateOfBirth,
                                 IdentityNumber = e.IdentityNumber,
                                 Picture = e.Picture,
                                 DepartmentName = d.DepartmentName

                             };
                return result.ToList();
            }
        }
    }
}
