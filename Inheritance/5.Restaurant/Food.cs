using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {

        public Food(string name, decimal price, double grams) 
            : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
        }

        public string Name { get; internal set; }

        public decimal Price { get; internal set; }

        public double Grams { get; internal set; }
    }
}
