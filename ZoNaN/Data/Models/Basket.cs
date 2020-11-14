using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int ProductId { get; set; }
        public bool isCompare { get; set; }
        public bool isWish { get; set; }
        public bool isCart { get; set; }
        public Chekout Chekout { get; set; }
        public ICollection<ProductBascet> ProductBascets { get; set; }
    }
}
