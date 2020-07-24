using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using WildFarm.Animals;
using WildFarm.Animals.Contracts;
using WildFarm.Core.Contracts;
using WildFarm.Exception2;
using WildFarm.Factories;
using WildFarm.Foods.Contracts;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;
        private FoodFactory foodFactory;

        public Engine()
        {
            this.animals = new List<IAnimal>();
            this.foodFactory = new FoodFactory();
        }

        public void Run()
        {
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string[] foodArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                IAnimal animal = ProduceAnimal(animalArgs);
                IFood food = this.foodFactory.ProduceFood(foodArgs[0], int.Parse(foodArgs[1]));

                this.animals.Add(animal);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Feed(food);
                }
                catch (UneateableFoodException ufe)
                {

                    Console.WriteLine(ufe.Message);
                }


            }

            foreach (IAnimal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal ProduceAnimal(string[] animalArgs)
        {
            IAnimal animal = null;

            string animalType = animalArgs[0];
            string name = animalArgs[1];
            double weigh = double.Parse(animalArgs[2]);

            if (animalType == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Owl(name, weigh, wingSize);
            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Hen(name, weigh, wingSize);
            }
            else
            {
                string livingRegion = animalArgs[3];

                if (animalType == "Dog")
                {
                    animal = new Dog(name, weigh, livingRegion);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weigh, livingRegion);
                }
                else
                {
                    string breed = animalArgs[4];

                    if (animalType == "Cat")
                    {
                        animal = new Cat(name, weigh, livingRegion, breed);
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(name, weigh, livingRegion, breed);
                    }
                }
            }

            return animal;
        }
    }
}
