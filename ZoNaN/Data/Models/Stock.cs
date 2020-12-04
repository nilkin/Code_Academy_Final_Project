using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
