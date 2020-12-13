using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Beverage : Product
    {
        private double milliliters;

        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters { get; internal set; }

        //public string Name { get; internal set; }

        //public decimal Price { get; internal set; }

    }
}
