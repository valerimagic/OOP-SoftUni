using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exe1Vehicle
{
    public class Bus : Vehicle
    {
        
        //private double fuelConsumptionWhenEmpty;
        

        public Bus(double fuelQuantity, double fuelConsumtion, double tankCapacity) 
            : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
            
           // this.fuelConsumptionWhenEmpty = fuelConsumtion;
            
        }

        public string BusDriveEmpty(double distance, string commandBus)
        {
            if(commandBus != "DriveEmpty")
            {
                this.fuelConsumption += 1.4;
            }

            if(this.fuelConsumption * distance <= this.fuelQuantity)
            {
                this.fuelQuantity -= distance * this.fuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        //public string BusDriveEmpty(double distance, string commandBus)
        //{

        //    if(commandBus == "DriveEmpty")
        //    {
        //        this.fuelConsumption = fuelConsumptionWhenEmpty;
        //        return base.CarTravelled(distance);
        //    }
            

        //    else
        //    {
        //        this.fuelConsumption = fuelConsumptionWhenEmpty + 1.4;
        //        return base.CarTravelled(distance);
        //    }

        //}

        //public override string CarTravell(double distance)
        //{
        //    return base.CarTravell(distance);
        //}


    }
}
