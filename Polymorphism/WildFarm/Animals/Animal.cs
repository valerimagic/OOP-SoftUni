using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals.Contracts;
using WildFarm.Exception2;
using WildFarm.Foods.Contracts;

namespace WildFarm.Animals
{
    public abstract class Animal : IAnimal
    {

        private const string UneatableFoodMessage = "{0} does not eat {1}!";
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        // Abstract because they are different for every type of animal
        public int FoodEaten { get; private set; }


        public abstract string ProduceSound();

        //List of all foods that are being eaten by this animal
        public abstract ICollection<Type> PrefferedFoods { get; }

        public abstract double WeightMultiplier { get; }
        public void Feed(IFood food)
        {
            if (!this.PrefferedFoods.Contains(food.GetType()))
            {
                throw new UneateableFoodException(string.Format(UneatableFoodMessage, this.GetType().Name, food.GetType().Name)); 
            }

            this.Weight += this.WeightMultiplier * food.Quantity;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }
    }
}
