using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.Concrete
{
    public class Expense:IEntity
    {
        public int ExpenseId { get; set; }
        public string ExpenseDescription { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal Total { get; set; }


    }
}
