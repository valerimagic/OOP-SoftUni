using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private const int foodPrice = 0;

        public Rebel(string name, string age, string group)
        {
            this.Food = foodPrice;
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }


        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Group { get; private set; }
        public int Food { get; private set; }

        public int BuyFood()
        {
            return this.Food += 5;
        }

    }
}
