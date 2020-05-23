using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Car
    {




        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }


        public void CarTravell(int distance)
        {

            if(this.FuelConsumption * distance < this.FuelQuantity)
            {
                Console.WriteLine("Car need refueling");
            }

            this.FuelQuantity -= distance * this.FuelConsumption;
        }

    }
}
