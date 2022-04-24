using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class InvoiceDetail:IEntity
    {
        public int InvoiceDetailId { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int InvoiceInfoId { get; set; }


    }
}
