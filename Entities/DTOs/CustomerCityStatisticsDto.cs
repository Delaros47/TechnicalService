using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class CustomerCityStatisticsDto:IDto
    {
        public string CityName { get; set; }
        public int TotalCustomers { get; set; }



    }
}
