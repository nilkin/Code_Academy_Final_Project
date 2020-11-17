using System.Collections.Generic;

namespace ZoNaN.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public bool isCompare { get; set; }
        public bool isWish { get; set; }
        public bool isCart { get; set; }
        public Chekout Chekout { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
