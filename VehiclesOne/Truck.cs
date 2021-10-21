using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesOne
{
    public class Truck : Vehicle
    {
        private const double truckSummer = 1.6;
        private const double tankFuel = 0.05;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += truckSummer;
        }

        public override void Refuel(double litres)
        {
            base.Refuel(litres);
            this.FuelQuantity -= litres * tankFuel;
        }
    }
}
