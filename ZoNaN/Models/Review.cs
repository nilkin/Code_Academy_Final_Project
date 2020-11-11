using System.Collections.Generic;

namespace ZoNaN.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}