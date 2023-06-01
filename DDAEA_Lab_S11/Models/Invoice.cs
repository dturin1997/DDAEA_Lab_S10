using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAEA_Lab_S11.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime Date { get; set; }
        List<Detail> Details { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}