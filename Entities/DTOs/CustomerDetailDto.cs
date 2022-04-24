using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities;

namespace Entities.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentityNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string Title { get; set; }
        public string CityName { get; set; }
        public string BankName { get; set; }


    }
}
