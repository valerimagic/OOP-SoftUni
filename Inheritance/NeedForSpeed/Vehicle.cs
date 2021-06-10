namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        private int horsePower;
        private double fuel;

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
            this.Fuel -= this.FuelConsumption() * kilometers;
        }
    }
}
