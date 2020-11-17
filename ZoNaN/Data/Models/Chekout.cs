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
        public bool IsGuest { get; set; }
        public string Message { get; set; }
        public int BasketId { get; set; }
        public Basket Bascet { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
