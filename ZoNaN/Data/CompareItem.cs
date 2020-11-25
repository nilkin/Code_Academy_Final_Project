using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data
{
    public class CompareItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public string Dimention { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int Qtity { get; set; }
        public CompareItem() { }

        public CompareItem(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Color = product.Color;
            Dimention = product.Size;
            Description = product.Description;
            Price = product.Stock.Price;
            Quantity = product.Stock.Quantity;
            Qtity = 1;
            Photo = product.ProductPhotos.ElementAt(0).Photo;
        }
    }
}
