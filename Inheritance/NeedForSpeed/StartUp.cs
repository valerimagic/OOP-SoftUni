namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var car = new Car(100, 100);

            car.Drive(10);

            System.Console.WriteLine(car.Fuel);

        }
    }
}
