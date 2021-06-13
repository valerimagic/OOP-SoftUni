using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animals>();

            while (true)
            {
                try
                {


                    string anim = Console.ReadLine();

                    if (anim == "Beast!")
                    {
                        break;
                    }

                    var input = Console.ReadLine().Split();

                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string gend = input[2];

                    if (anim == "Cat")
                    {
                        animals.Add(new Cat(name, age, gend));
                    }
                    else if (anim == "Dog")
                    {
                        animals.Add(new Dog(name, age, gend));
                    }
                    else if (anim == "Frog")
                    {
                        animals.Add(new Frog(name, age, gend));
                    }
                    else if (anim == "Kitten")
                    {
                        animals.Add(new Kitten(name, age));
                    }
                    else if (anim == "Tomcat")
                    {
                        animals.Add(new Tomcat(name, age));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException msg)
                {
                    Console.WriteLine(msg.Message);
                }
            }

            animals.ForEach(Console.WriteLine);


        }
    }
}
