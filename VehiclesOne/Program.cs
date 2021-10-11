using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VehiclesOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var truckInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var busInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var fuelCar = double.Parse(carInput[1]);
            var consumCar = double.Parse(carInput[2]);
            var tankCapacityCar = double.Parse(carInput[3]);

            var fuelTruck = double.Parse(truckInput[1]);
            var consumTruck = double.Parse(truckInput[2]);
            var tankCapacityTruck = double.Parse(truckInput[3]);
            
            var fuelBus = double.Parse(busInput[1]);
            var consumBus = double.Parse(busInput[2]);
            var tankCapacityBus = double.Parse(busInput[3]);

            Car car = new Car(fuelCar, consumCar, tankCapacityCar);
            Truck truck = new Truck(fuelTruck, consumTruck, tankCapacityTruck);
            Bus bus = new Bus(fuelBus, consumBus, tankCapacityBus);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var command = input[0];
                    var vehicle = input[1];
                    var value = double.Parse(input[2]);

                    if (command == "Drive")
                    {
                        if (vehicle == "Car")
                        {

                            Console.WriteLine(car.Drive(value));
                        }
                        else if (vehicle == "Truck")
                        {
                            Console.WriteLine(truck.Drive(value));
                        }
                        else if (vehicle == "Bus")
                        {
                            Console.WriteLine(bus.Drive(value));
                        }
                    }

                    else if (command == "Refuel")
                    {
                        if (vehicle == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.Refuel(value);
                        }
                    }

                    else if (command == "DriveEmpty")
                    {
                        Console.WriteLine(bus.DriveBusEmpty(value));
                    }
                }
                catch (Exception exceptionMssages)
                {
                    Console.WriteLine(exceptionMssages.Message);
                    
                }
                


            }

            Console.WriteLine(car.ToString().TrimEnd());
            Console.WriteLine(truck.ToString().TrimEnd());
            Console.WriteLine(bus.ToString().TrimEnd());



        }
    }
}
