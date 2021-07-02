using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiabee> identifiabees = new List<IIdentifiabee>();

            string input = Console.ReadLine();

            while(input != "End")
            {
                var passingerInfo = input.Split();
                if(passingerInfo.Length == 3)
                {
                    identifiabees.Add(new Citizen(passingerInfo[0], int.Parse(passingerInfo[1]), passingerInfo[2]));
                }
                else
                {
                    identifiabees.Add(new Robot(passingerInfo[0], passingerInfo[1]));
                }




                input = Console.ReadLine();
            }

            string lastDigit = Console.ReadLine();

            identifiabees.Where(c=>c.Id.EndsWith(lastDigit))
                .ToList()
                .ForEach(p=>Console.WriteLine(p.Id));
        }
    }
}
