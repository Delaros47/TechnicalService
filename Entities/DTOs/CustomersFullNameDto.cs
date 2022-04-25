using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class CustomersFullNameDto:IDto
    {
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }

    }
}
