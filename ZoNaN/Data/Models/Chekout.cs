using System.Collections.Generic;
using ZoNaN.Data.Models;

namespace ZoNaN.Models
{
    public class Chekout
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string ChekoutNumber { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string Agreement { get; set; }
        public bool Shipping { get; set; }
        public string Message { get; set; }
        public Customer Customer { get; set; }
        public double  ChekoutTotalAmount { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
