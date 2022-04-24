using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class Malfunction:IEntity
    {

        public int MalfunctionId { get; set; }
        public int ProductAcceptanceId { get; set; }
        public string Issues { get; set; }
        public string IssuesDescription { get; set; }
        public decimal EstimatedPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string FixedIssues { get; set; }


    }
}
