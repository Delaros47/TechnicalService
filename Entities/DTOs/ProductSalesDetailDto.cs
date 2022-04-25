using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class ProductSalesDetailDto:IDto
    {
        public int ProductSaleId { get; set; }
        public string ProductName { get; set; }
        public string CustomerFullName { get; set; }
        public string EmployeeFullName { get; set; }
        public DateTime SalesDate { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public string ProductSeriesNumber { get; set; }

    }
}
