﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data
{
    public class BasketItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ProdQuantity { get; set; }
        public double Price { get; set; }
        public double Total { get { return Quantity * Price; }}
        public string Photo { get; set; }

        public BasketItem() {}

        public BasketItem(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Stock.Price;
            ProdQuantity = product.Stock.Quantity;
            Quantity = 1;
            Photo = product.ProductPhotos.FirstOrDefault(c => c.IsFirstPhoto).Photo;
        }
    }
}
