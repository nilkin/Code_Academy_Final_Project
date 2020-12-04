using ZoNaN.Models;

namespace ZoNaN.Data.Models
{ 
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string Photo { get; set; }
        public int ChekoutId { get; set; }
        public Chekout Chekout { get; set; }
    }
}
