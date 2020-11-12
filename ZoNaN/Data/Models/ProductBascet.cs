using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Models
{
    public class ProductBascet
    {
        public int Id { get; set; }
        public int BascetId { get; set; }
        public int ProductId { get; set; }
        public Basket Bascet { get; set; }
        public Product Product { get; set; }
    }
}
