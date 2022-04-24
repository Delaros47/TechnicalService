using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class ProductSale:IEntity
    {
        public int ProductSaleId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SalesDate { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public string ProductSeriesNumber { get; set; }


    }
}
