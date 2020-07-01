using System;

namespace Exe1Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {



            var inputCar = Console.ReadLine().Split();
            double fuelQCar = double.Parse(inputCar[1]);
            double fuelConsCar = double.Parse(inputCar[2]);
            double tankCapacityCar = double.Parse(inputCar[3]);
            if (fuelQCar > tankCapacityCar)
            {
                tankCapacityCar = 0;
            }

            var inputTruck = Console.ReadLine().Split();
            double fuelQTruck = double.Parse(inputTruck[1]);
            double fuelConsTruck = double.Parse(inputTruck[2]);
            double tankCapacityTruck = double.Parse(inputTruck[3]);
            if (fuelQTruck > tankCapacityTruck)
            {
                tankCapacityTruck = 0;
            }

            var inputBus = Console.ReadLine().Split();
            double fuelQBus = double.Parse(inputBus[1]);
            double fuelConsBus = double.Parse(inputBus[2]);
            double tankCapacityBus = double.Parse(inputBus[3]);
            if (fuelQBus > tankCapacityBus)
            {
                tankCapacityBus = 0;
            }

            double num = double.Parse(Console.ReadLine());

            Vehicle car = new Car(fuelQCar, fuelConsCar, tankCapacityCar);
            Vehicle truck = new Truck(fuelQTruck, fuelConsTruck, tankCapacityTruck);
            Vehicle bus = new Bus(fuelQBus, fuelConsBus, tankCapacityBus);

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split();
                try
                {

                    if (input[0] == "Drive")
                    {
                        if (input[1] == "Car")
                        {
                            Console.WriteLine(car.CarTravelled(double.Parse(input[2])));
                        }
                        else if (input[1] == "Truck")
                        {
                            Console.WriteLine(truck.CarTravelled(double.Parse(input[2])));
                        }
                        else if (input[1] == "Bus")
                        {
                            Console.WriteLine(((Bus)bus).BusDriveEmpty(double.Parse(input[2]), input[0]));
                        }
                    }
                    else if (input[0] == "Refuel")
                    {
                        if (input[1] == "Car")
                        {
                            car.Refuel(double.Parse(input[2]));

                        }

                        else if (input[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(input[2]));
                        }

                        else if (input[1] == "Bus")
                        {
                            bus.Refuel(double.Parse(input[2]));
                        }
                    }
                    else if (input[0] == "DriveEmpty")
                    {
                        Console.WriteLine(((Bus)bus).BusDriveEmpty(double.Parse(input[2]), input[0]));
                    }


                }

                catch (ArgumentException messages)
                {

                    Console.WriteLine(messages.Message);
                }
            }


            Console.WriteLine($"Car: {car.CurrentFuel():F2}");
            Console.WriteLine($"Truck: {truck.CurrentFuel():F2}");
            Console.WriteLine($"Bus: {bus.CurrentFuel():F2}");
        }



    }
}



    
    

