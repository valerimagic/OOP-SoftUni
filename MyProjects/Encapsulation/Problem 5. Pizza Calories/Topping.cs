using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private double weight;
        private string toppingType;

        public Topping(double weight, string toppingType)
        {
            this.Weight = weight;
            this.ToppingType = toppingType;
        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range[1..50].");
                }

                this.weight = value;
            }
        }

        public string ToppingType
        {
            get => this.toppingType;
            set
            {
                if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sause")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        public double CalculateTopping(double Weight)
        {
            double result = this.Weight * this.ToppingTypeConstant(this.)
        }

        public double ToppingTypeConstant(string toppingType)
        {
            if (toppingType == "Meat")
            {
                return 1.2;
            }
            else if (toppingType == "Veggies")
            {
                return 0.8;
            }
            else if (toppingType == "Cheese")
            {
                return 1.1;
            }
            else if (toppingType == "Sause")
            {
                return 0.9;
            }

            return 2.0;
        }
    }
}
