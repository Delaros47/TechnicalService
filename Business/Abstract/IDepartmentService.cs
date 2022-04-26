using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;
using Universal.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IDepartmentService
    {

        IDataResult<List<Department>> GetAll();
        IDataResult<Department> Get(int departmentId);
        IDataResult<List<DepartmentEmployeeDto>> GetDepartmentEmployeeDto();
        IResult Add(Department department);
        IResult Update(Department department);
        IResult Delete(Department department);


    }
}
