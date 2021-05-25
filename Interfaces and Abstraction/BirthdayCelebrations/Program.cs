using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> list = new List<IBuyer>();

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    list.Add(new Citizen(input[0], input[1], input[2], input[3]));
                }

                else if (input.Length == 3)
                {
                    list.Add(new Rebel(input[0], input[1], input[2]));
                }

            }

            string name = Console.ReadLine();
            int sum = 0;

            while (name != "End")
            {

                IBuyer result = list.Where(x => x.Name == name).FirstOrDefault();

                if (result != null)
                {
                    int currentFood = result.Food;
                    result.BuyFood();
                    sum += result.Food - currentFood;
                }

                name = Console.ReadLine();



                //if (newInput[0] == "Citizen")
                //{
                //    //DateTime birthdate = DateTime.ParseExact(newInput[4], "dd/MM/yyyy", null);
                //    list.Add(new Citizen(newInput[1], newInput[2], newInput[3], newInput[4]));
                //}
                //else if (newInput[0] == "Pet")
                //{
                //    //DateTime birthdate = DateTime.ParseExact(newInput[2], "dd/MM/yyyy", null);
                //    list.Add(new Pet(newInput[1], newInput[2]));
                //}

            }
                Console.WriteLine(sum);

            



            //string number = Console.ReadLine();

            //foreach (var item in list.Where(c => c.Birthday.EndsWith(number)))
            //{
            //   Console.WriteLine(item.Birthday);
            //}



            //list.Where(c => c.Birthday.Year == number)
            //.ToList()
            //.ForEach(c => Console.WriteLine(string.Format($"{c.Birthday:dd/MM/yyy}")));



        }
    }
}
