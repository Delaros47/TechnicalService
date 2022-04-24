using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class Tracking:IEntity
    {
        public int TrackingId { get; set; }
        public string TrackingNumber { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }


    }
}
