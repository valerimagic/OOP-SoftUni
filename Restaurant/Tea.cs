using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Tea : Beverages
    {
        public Tea(string name, decimal price, double milliliter) : base(name, price, milliliter)
        {
        }
    }
}
