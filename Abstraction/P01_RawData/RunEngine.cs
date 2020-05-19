using StartUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RawData
{
    public class RunEngine
    {
        List<Car> cars = new List<Car>();


        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                Car newCar = CreateCar();
                cars.Add(newCar);
            }

            string command = Console.ReadLine();
            CheckCommand(command);
        }

        public void CheckCommand(string command)
        {
            if (command == "fragile")
            {
                var fragile = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tire.Any(t => t.Pressure < 1))
                .Select(x => x.Model)
                .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                var flamable = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        public Car CreateCar()
        {

            string[] parameters = Console.ReadLine().Split();

            string model = parameters[0];

            int speed = int.Parse(parameters[1]);
            int power = int.Parse(parameters[2]);
            Engine engine = new Engine(speed, power);



            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            double tire1Pressure = double.Parse(parameters[5]);
            int tire1age = int.Parse(parameters[6]);
            double tire2Pressure = double.Parse(parameters[7]);
            int tire2age = int.Parse(parameters[8]);
            double tire3Pressure = double.Parse(parameters[9]);
            int tire3age = int.Parse(parameters[10]);
            double tire4Pressure = double.Parse(parameters[11]);
            int tire4age = int.Parse(parameters[12]);
            Tire[] tires = new Tire[4]
            {
                    new Tire(tire1Pressure, tire1age),
                    new Tire(tire2Pressure, tire2age),
                    new Tire(tire3Pressure, tire3age),
                    new Tire(tire4Pressure, tire4age)
            };

            Car car = new Car(model, engine, cargo, tires);
            return car;

            //cars.Add(new Car(model, engine, cargo, tires));
        }






    }
}
