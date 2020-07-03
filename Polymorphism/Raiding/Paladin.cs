using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int powerPaladin = 100;
        public Paladin(string name) : base(name)
        {
            this.Power = powerPaladin;
        }

        public override string CastAbility()
        {
            return $"Paladin - {this.Name} healed for {this.Power}";
        }
    }
}
