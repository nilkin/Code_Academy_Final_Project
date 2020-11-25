using System.Collections.Generic;
using ZoNaN.Data.Models;

namespace ZoNaN.Models
{
    public class OrderChekout
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int? ChekoutId { get; set; }
        public Chekout Chekout { get; set; }
    }
}
