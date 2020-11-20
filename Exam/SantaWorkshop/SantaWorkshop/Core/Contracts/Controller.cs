using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Repositories;
using SantaWorkshop.Repositories.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Core.Contracts
{
    public class Controller : IController
    {

        private DwarfRepository dwarfs;
        private PresentRepository presents;
        

        public Controller()
        {
            this.dwarfs = new DwarfRepository();
            this.presents = new PresentRepository();
        }


        public string AddDwarf(string dwarfType, string dwarfName)
        {
            IDwarf dwarf;

            if (dwarfType == nameof(HappyDwarf))
            {
                dwarf = new HappyDwarf(dwarfName);
            }

            else if (dwarfType == nameof(SleepyDwarf))
            {
                dwarf = new SleepyDwarf(dwarfName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }
            this.dwarfs.Add(dwarf);

            string result = string.Format(OutputMessages.DwarfAdded, dwarfType, dwarfName);

            return result;
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            IInstrument instrument;

            IDwarf dwarf = this.dwarfs.FindByName(dwarfName);
            //IDwarf dwarf = dwarf.;
            if (dwarf == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }
            
            instrument = new Instrument(power);
            dwarf.AddInstrument(instrument);
            return string.Format(OutputMessages.InstrumentAdded, power, dwarfName);

        }

        public string AddPresent(string presentName, int energyRequired)
        {
            IPresent present = new Present(presentName, energyRequired);
            this.presents.Add(present);
            return string.Format(OutputMessages.PresentAdded, presentName);

        }

        public string CraftPresent(string presentName)
        {
            IPresent present = this.presents.FindByName(presentName);

            ICollection<IDwarf> dwarves = this.dwarfs.Models.Where(dw => dw.Energy >= 50).OrderByDescending(dw => dw.Energy).ToList();

            if (dwarves.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }

            Workshop workshop = new Workshop();

            while (dwarves.Any())  // dokato ima djudjeta
            {
                IDwarf currDwarf = dwarves.First();

                workshop.Craft(present, currDwarf);

                if (!currDwarf.Instruments.Any())
                {
                    dwarves.Remove(currDwarf);
                }
                if(currDwarf.Energy == 0)
                {
                    dwarves.Remove(currDwarf);
                   //this.dwarfs.Remove(currDwarf);
                }

                if (present.IsDone())
                {
                    break;
                }


            }

                string output = string.Format(present.IsDone() ? OutputMessages.PresentIsDone : OutputMessages.PresentIsNotDone, presentName);

                return output;




        }

        public string Report()
        {
            int countCraftedPre = this.presents.Models.Count(x => x.IsDone());


            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{countCraftedPre} presents are done!")
              .AppendLine("Dwarfs info:");
            


            foreach (var itemDwarf in this.dwarfs.Models)
            {
                int countInstruments = itemDwarf.Instruments.Count(x => !x.IsBroken());
                sb.AppendLine($"Name: {itemDwarf.Name}");
                sb.AppendLine($"Energy: {itemDwarf.Energy}");
                sb.AppendLine($"Instruments: {countInstruments} not broken left");

            }

            return sb.ToString().TrimEnd();

           

        }
    }
}
