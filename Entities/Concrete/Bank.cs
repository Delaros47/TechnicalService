using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class Bank:IEntity
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string BankDescription { get; set; }

    }
}
