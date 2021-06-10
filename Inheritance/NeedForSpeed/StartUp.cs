namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(0, 200);
            SportCar sportCar = new SportCar(0, 100);

            sportCar.FuelConsumption();
            car.Drive(10);

            System.Console.WriteLine(car.Fuel);
            System.Console.WriteLine(sportCar.FuelConsumption());
        }
    }
}
