using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAEA_Lab_S11.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}