using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Races.Entities
{
    public class Race
    {
        //private string name;
        //private int laps;
        ////private IList<IDriver> drivers;

        //public Race()
        //{
        //    //this.drivers=new List<IDriver>();
        //}

        //public Race(string name, int laps):this()
        //{
        //    this.Name = name;
        //    this.Laps = laps;
        //}

        //public string Name
        //{
        //    get => this.name;
        //    private set
        //    {
        //        if (string.IsNullOrEmpty(value) || value.Length < 5)
        //        {
        //            throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
        //        }

        //        this.name = value;
        //    }
        //}

        //public int Laps
        //{
        //    get => this.laps;
        //    private set
        //    {
                //if (value < 1)
                //{
                //    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, 1));
                //}

        //        this.laps = value;
        //    }
        //}

        //public IReadOnlyCollection<IDriver> Drivers => (IReadOnlyCollection<IDriver>)this.drivers;


        //public void AddDriver(IDriver driver)
        //{
            //if (driver == null)
            //{
            //    throw new ArgumentNullException(ExceptionMessages.DriverInvalid);
            //}

            //if (!driver.CanParticipate) //== false)
            //{
            //    throw new AggregateException(string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            //}

            //if (this.drivers.Any(x => x.Name == driver.Name))
            //{
            //    throw new ArgumentNullException(string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name));
            //}
            
            //drivers.Add(driver);
            
        //}
    }
}
