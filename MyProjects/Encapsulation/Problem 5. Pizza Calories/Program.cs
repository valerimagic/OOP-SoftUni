using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string inp = input[0];
            string doughType = input[1];
            string tehnique = input[2];
            double doughGrams = double.Parse(input[3]);

            try
            {
                Dough dough = new Dough(doughType, tehnique, doughGrams);

                Console.WriteLine(dough.Calculate().ToString("f2"));
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

           

        }
    }
}
