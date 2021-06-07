using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        //•	A constructor that accepts the following parameters: int horsePower, double fuel
        //•	DefaultFuelConsumption – double 
        //•	FuelConsumption – virtual double
        //•	Fuel – double
        //•	HorsePower – int

        //•	virtual void Drive(double kilometers)
        //o The Drive method should have a functionality to reduce the Fuel based on the travelled kilometers.
        //The default fuel consumption for Vehicle is 1.25.
        

        //Some of the classes have different default fuel consumption values:
        //•	SportCar – DefaultFuelConsumption = 10
        //•	RaceMotorcycle – DefaultFuelConsumption = 8
        //•	Car – DefaultFuelConsumption = 3

        private int horsePower;
        private double fuel;
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; private set; }
        public double Fuel { get; private set; }

        public virtual double FuelConsumption()
        {
            return 1.25;

        }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (FuelConsumption() * kilometers);
        }
    }
}
