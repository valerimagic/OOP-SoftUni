using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        //private int foodEaten;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }


        public virtual string ProduceSound()
        {
            return "Sound";
        }

        public virtual void AnimalEat(Food food, double animalCoeficient)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * animalCoeficient;
        }
    }
}
