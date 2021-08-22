using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {

            var heros = new List<BaseHero>();

            int number = int.Parse(Console.ReadLine());

            while(heros.Count != number)
            {
                string name = Console.ReadLine();
                string hero = Console.ReadLine();

                if (hero == "Druid")
                {

                    Druid druid = new Druid(name);
                    heros.Add(druid);
                    //druid.CastAbility();
                }
                else if (hero == "Paladin")
                {
                    Paladin paladin = new Paladin(name);
                    heros.Add(paladin);
                    //paladin.CastAbility();
                }
                else if (hero == "Rogue")
                {
                    Rogue rogue = new Rogue(name);
                    heros.Add(rogue);
                    //rogue.CastAbility();
                }

                else if (hero == "Warrior")
                {
                    Warrior warrior = new Warrior(name);
                    heros.Add(warrior);
                    //warrior.CastAbility();
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }


            }

            
            int baseHero = int.Parse(Console.ReadLine());
            int count = 0;

            foreach (var hero in heros)
            {
                Console.WriteLine(hero.CastAbility());
                count += hero.Power;
            }

            if (baseHero > count)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }


        }
    }
}
