using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesOne
{
    public class Car : Vehicle
    {
        private const double carSummer = 0.9;
        private double tankCapacity;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += carSummer;
        }

        
    }
}
