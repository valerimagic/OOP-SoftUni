using System;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine().Split();

            ICalling number10 = new Smartphone();
            ICalling number7 = new StationaryPhone();


            foreach (var number in inputNumber)
            {
                if (number.All(char.IsDigit))
                {

                    if (number.Length == 10)
                    {
                        number10.Call(number);
                    }
                    else
                    {
                        number7.Call(number);
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid number!");
                }
            }

            var inputWebSites = Console.ReadLine().Split();

            IBrowsable browsable = new Smartphone();

            foreach (var urlSites in inputWebSites)
            {
                if (!urlSites.Any(char.IsDigit))
                {
                    browsable.Browse(urlSites);
                }

                else
                {
                    Console.WriteLine($"Invalid URL!");
                }
            }
        }
    }
}
