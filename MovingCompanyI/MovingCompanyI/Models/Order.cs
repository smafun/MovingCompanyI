using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovingCompanyI.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Customer Id From")]
        public int CustomerId { get; set; }
        [Display(Name = "Adress From")]
        public String AddressFrom { get; set; }
        [Display(Name = "Adress To")]
        public String AddressTo { get; set; }
        public String ServiceType { get; set; }
        public String TextField { get; set; }
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }

        public ICollection<ServiceType> ServiceTypes { get; set; }
    }
}
