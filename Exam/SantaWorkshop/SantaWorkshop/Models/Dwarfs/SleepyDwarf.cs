using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    public class SleepyDwarf : Dwarf
    {

        private const int initialEnergySleepyDwarf = 50;


        public SleepyDwarf(string name) 
            : base(name, initialEnergySleepyDwarf)
        {
        }

        public override void Work()
        {
            base.Work();

            this.Energy -= 5;
        }
    }
}
