using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class DepartmentEmployeeDto : IDto
    {

        public string DepartmentName { get; set; }
        public int EmployeeNumber { get; set; }

    }
}
