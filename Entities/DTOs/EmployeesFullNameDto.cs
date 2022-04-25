using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class EmployeesFullNameDto:IDto
    {

        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }


    }
}
