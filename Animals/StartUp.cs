using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<Animal>();




            while (input != "Beast!")
            {

                var anim = Console.ReadLine().Split().ToArray();
                try
                {

                    if (input == "Cat")
                    {
                        Cat cat = new Cat(anim[0], int.Parse(anim[1]), anim[2]);
                        list.Add(cat);
                    }

                    else if (input == "Dog")
                    {
                        Dog dog = new Dog(anim[0], int.Parse(anim[1]), anim[2]);
                        list.Add(dog);
                    }

                    else if (input == "Frog")
                    {
                        Frog dog = new Frog(anim[0], int.Parse(anim[1]), anim[2]);
                        list.Add(dog);
                    }
                }
                catch (Exception messages)
                {
                    Console.WriteLine(messages.Message);
                }

                input = Console.ReadLine();

            }

            foreach (var VARIABLE in list)
            {
                Console.WriteLine($"{VARIABLE.GetType().Name}");
                Console.WriteLine($"{VARIABLE.Name} {VARIABLE.Age} {VARIABLE.Gender}");
                Console.WriteLine($"{VARIABLE.ProduceSound()}");
            }


        }
    }
}
