using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAEA_Lab_S11.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }
    }
}