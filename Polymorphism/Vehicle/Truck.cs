using System;
using System.Collections.Generic;
using System.Text;

namespace Exe1Vehicle
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            this.fuelQuantity -= liters * 0.05;
        }
    }
}
