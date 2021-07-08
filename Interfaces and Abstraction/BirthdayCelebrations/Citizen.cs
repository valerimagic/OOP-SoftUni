using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IId, IBirthdayable, IBuyer
    {
        public Citizen(string name, string age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }

        public string Birthday { get; private set; }

        public int Food { get; private set; }

        public int BuyFood()
        {
            return this.Food += 10;
        }

    }

}
