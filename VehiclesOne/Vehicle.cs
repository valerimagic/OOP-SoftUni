using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace VehiclesOne
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                //else
                //{
                    this.fuelQuantity = value;

                //}
                
            }
        }
        public double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        public double TankCapacity
        {
            get { return this.tankCapacity;}

            set { this.tankCapacity = value; }

        }

        public virtual void Refuel(double litres)
        {
            double newFuel = this.FuelQuantity + litres;

            if (newFuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litres} fuel in the tank");
            }
            else if (litres <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += litres;
        }

        public virtual string Drive(double kilometers)
        {
            double needFuel = this.FuelConsumption * kilometers;
            if (needFuel > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            else
            {
              this.FuelQuantity -= needFuel;
              return $"{this.GetType().Name} travelled {kilometers} km";

            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
