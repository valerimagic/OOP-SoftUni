using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<BaseHero> baseHero = new List<BaseHero>();

            for (int i = 0; i < number; i++)
            {
                var name = Console.ReadLine();
                var theCode = Console.ReadLine();
                
                if(theCode == "Paladin")
                {
                    var paladin = new Paladin(name);
                    baseHero.Add(paladin);
                }

                else if(theCode == "Druid")
                {
                    var druid = new Druid(name);
                    baseHero.Add(druid);
                }

                else if(theCode == "Warrior")
                {
                    var warrior = new Warrior(name);
                    baseHero.Add(warrior);
                    
                }

                else if(theCode == "Rogue")
                {
                    var rogue = new Rogue(name);
                    baseHero.Add(rogue);
                }

                else
                {
                    i--;
                    Console.WriteLine("Invalid hero!");
                }


            }

            int pointTheBoss = int.Parse(Console.ReadLine());

                int sum = 0;
            foreach (var item in baseHero)
            {
                int currentSum = item.Power;
                sum += currentSum;
                currentSum = 0;
                Console.WriteLine(item.CastAbility());
            }

            if(sum >= pointTheBoss)
            {
                Console.WriteLine("Victory!");
            }

            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
