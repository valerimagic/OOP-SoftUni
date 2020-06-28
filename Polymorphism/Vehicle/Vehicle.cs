using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exe1Vehicle
{
    public class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;


        public Vehicle(double fuelQuantity, double fuelConsumtion, double tankCapacity)
        {
            this.tankCapacity = tankCapacity;
            this.fuelQuantity = fuelQuantity; // <= tankCapacity ? fuelQuantity : 0;
            this.fuelConsumption = fuelConsumtion;
        }

        //public double FuelConsumption { get; set; }

        public virtual double CurrentFuel()
        {
            return this.fuelQuantity;
        }

        public virtual string CarTravelled(double distance)
        {

            if (this.fuelConsumption * distance <= this.fuelQuantity)
            {
                this.fuelQuantity -= distance * this.fuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            else
            {
                return $"{this.GetType().Name} needs refueling";
            }

        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (liters + this.CurrentFuel() > this.tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.fuelQuantity += liters;
            }
        }




    }
}
