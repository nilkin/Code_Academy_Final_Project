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
        public int Price { get; set; }
        public int PoductId { get; set; }
        public Product Product  { get; set; }
    }
}
