using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class ProductAcceptanceDetailDto:IDto
    {

        public int ProductAcceptanceId { get; set; }
        public string CustomerFullName { get; set; }
        public string EmployeeFullName { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeftDate { get; set; }
        public string ProductSeriesNumber { get; set; }


    }
}
