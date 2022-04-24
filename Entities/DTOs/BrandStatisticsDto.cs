using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class BrandStatisticsDto:IDto
    {

        public string BrandName { get; set; }
        public int TotalProducts { get; set; }


    }
}
