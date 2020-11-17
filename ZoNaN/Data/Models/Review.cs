using System;
using System.Collections.Generic;

namespace ZoNaN.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public byte Rate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime AddedDate { get; set; }
    }
}