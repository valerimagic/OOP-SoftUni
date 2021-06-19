using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IBuyer
    {
        int BuyFood();

        public int Food { get; }

        public string Name { get; }
    }

}
