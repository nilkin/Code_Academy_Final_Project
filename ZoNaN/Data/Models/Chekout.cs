using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Models
{
    public class Chekout
    {
        public int Id { get; set; }
        public bool Payment { get; set; }
        public bool Shipping { get; set; }
        public string Message { get; set; }
        public ICollection<Basket> Bascets { get; set; }
        public Customer Customer { get; set; }
    }
}
