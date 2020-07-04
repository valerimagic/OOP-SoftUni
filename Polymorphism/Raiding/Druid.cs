using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int powerDruid = 80;

        public Druid(string name) 
            : base(name)
        {
            this.Power = powerDruid;
        }

        public override string CastAbility()
        {
            return $"Druid - {this.Name} healed for {this.Power}";
        }
    }
}
