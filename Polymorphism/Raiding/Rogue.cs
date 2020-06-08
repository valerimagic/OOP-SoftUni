using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int roguePower = 80;
        public Rogue(string name) : base(name)
        {
            this.Power = roguePower;
        }

        public override string CastAbility()
        {
            return $"Rogue - {this.Name} hit for {this.Power} damage";
        }
    }
}
