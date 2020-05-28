using System;
using System.Collections.Generic;
using System.Text;

namespace Exe1Vehicle
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + 0.9, tankCapacity)
        {
        }
    }
}
