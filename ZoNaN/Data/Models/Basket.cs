using System.Collections.Generic;

namespace ZoNaN.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public bool isCompare { get; set; }
        public bool isWish { get; set; }
        public bool isCart { get; set; }
        public Chekout Chekout { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
