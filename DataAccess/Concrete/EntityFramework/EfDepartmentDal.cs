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
    public class EfDepartmentDal:EfEntityRepositoryBase<Department,TechinalServiceContext>,IDepartmentDal
    {
        public List<DepartmentEmployeeDto> GetDepartmentEmployeeDto()
        {
            using (var context = new TechinalServiceContext())
            {
                var result = from d in context.Departments
                    join e in context.Employees
                        on d.DepartmentId equals e.EmployeeId
                    group d.DepartmentName by d.DepartmentName
                    into groupDepartment
                    select new DepartmentEmployeeDto
                    {
                        DepartmentName = groupDepartment.Key,
                        EmployeeNumber = groupDepartment.Count()
                    };
                return result.ToList();
            }
        }
    }
}
