using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
    public class Product
    {
        public int id { get;}
        private string Name { get; set; }
        public double Price { get;}
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(int id, string name,double price, int quantity)
        {
            this.id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
