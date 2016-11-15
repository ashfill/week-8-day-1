using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}