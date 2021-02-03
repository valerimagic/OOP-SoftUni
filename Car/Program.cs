using System;

namespace CarParking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();

            for (int i = 0; i < 5; i++)
            {
                parking.AddCar(new Car("AlfaRomeo"));
                //parking.Cars.Add(new Car("Volvo"));
            }
            foreach (var car in parking.Cars)
            {
                Console.WriteLine(car.Name);
            }


        }
    }
}
