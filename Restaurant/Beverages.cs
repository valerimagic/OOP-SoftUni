using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Beverages : Product
    {
        private double milliliters;
        public Beverages(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters
        {
            get;
            internal set;
        }
    }
    
}
