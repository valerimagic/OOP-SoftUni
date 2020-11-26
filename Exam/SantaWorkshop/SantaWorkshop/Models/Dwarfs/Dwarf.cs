using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    public abstract class Dwarf : IDwarf
    {
        private int energy;
        private string name;
        private readonly IList<IInstrument> instruments;

        protected Dwarf(string name, int energy) 
            :this()
        {
            this.Name = name;
            this.Energy = energy;
        }

        protected Dwarf()
        {
            this.instruments = new List<IInstrument>();

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDwarfName);
                }
                this.name = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }

            protected set
            {
                if(value < 0) // this.energy > 0 ? value : 0;
                {
                    this.energy = 0;
                }
                this.energy = value;
            }
        }

        public ICollection<IInstrument> Instruments { get; }

        public void AddInstrument(IInstrument instrument)
        {
            instruments.Add(instrument);
        }

        public virtual void Work()
        {
            this.Energy -= 10;
        }
    }
}
