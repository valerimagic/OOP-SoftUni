using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> produkts = new List<Product>();

            var inputPeoples = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();

            var products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in inputPeoples)
            {
                var input = item.Split("=", StringSplitOptions.RemoveEmptyEntries).ToList();

                try
                {
                    people.Add(new Person(input[0], decimal.Parse(input[1])));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            foreach (var item in products)
            {
                var input = item.Split("=", StringSplitOptions.RemoveEmptyEntries).ToList();

                try
                {
                    produkts.Add(new Product(input[0], decimal.Parse(input[1])));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var command = Console.ReadLine();

            while (command != "END")
            {

                var input = command.Split().ToArray();
                var personName = input[0];
                var productName = input[1];

                try
                {
                    people.Find(p => p.Name == personName).Buy(produkts.Find(p => p.Name == productName));
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (Exception)
                {

                    throw;
                }



                command = Console.ReadLine();
            }


        }
    }
}
