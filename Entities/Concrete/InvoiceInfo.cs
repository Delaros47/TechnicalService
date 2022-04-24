using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class InvoiceInfo:IEntity
    {
        public int InvoiceInfoId { get; set; }
        public string InvoiceSerialNumber { get; set; }
        public string InvoiceOrderNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string TaxOffice { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }


    }
}
