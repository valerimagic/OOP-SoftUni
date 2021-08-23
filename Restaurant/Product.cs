using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Product
    {
        //private string name;
        //private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }


        public string Name { get; private set; }
        public decimal Price { get; internal set; }


    }
}
