namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];

                try
                {
                    if (command == "Cat")
                    {
                        animals.Add(new Cat(name, age, gender));
                    }
                    else if (command == "Dog")
                    {
                        animals.Add(new Dog(name, age, gender));
                    }
                    else if (command == "Frog")
                    {
                        animals.Add(new Frog(name, age, gender));
                    }
                    else if (command == "Tomcat")
                    {
                        animals.Add(new Tomcat(name, age));
                    }
                    else if (command == "Kitten")
                    {
                        animals.Add(new Kitten(name, age));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
