using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class ProductAcceptance:IEntity
    {
        public int ProductAcceptanceId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeftDate { get; set; }


    }
}
