using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAEA_Lab_S11.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }
}