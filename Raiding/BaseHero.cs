using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        //private string name;
        //private int power;

        public BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name { get; set; }
        public int Power { get; set; }




        public virtual string CastAbility()
        {
            return $"{GetType().Name} – {this.Name} healed for {this.Power}";
        }




    }
}
