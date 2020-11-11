using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoNaN.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }

    }
}