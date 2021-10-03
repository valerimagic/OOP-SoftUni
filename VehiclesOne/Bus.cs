using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesOne
{
    public class Bus : Vehicle
    {
        //private double tankCapacity;
        private const double aerCondition = 1.4;



        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += aerCondition;
        }

        public string DriveBusEmpty(double distance)
        {
            this.FuelConsumption -= aerCondition;
            return base.Drive(distance);
        }
    }
}
