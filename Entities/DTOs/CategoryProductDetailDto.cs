using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class CategoryProductDetailDto:IDto
    {
        public string CategoryName { get; set; }
        public int ProductNumber { get; set; }

    }
}
