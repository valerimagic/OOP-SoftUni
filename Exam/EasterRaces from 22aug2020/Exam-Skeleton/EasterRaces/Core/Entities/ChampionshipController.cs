using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private CarRepository cars;
        private DriverRepository drivers;
        private RaceRepository races;

        public ChampionshipController()
        {
            cars = new CarRepository();
            drivers = new DriverRepository();
            races = new RaceRepository();

        }

        public string CreateDriver(string driverName)
        {
            var driver = drivers.Models.FirstOrDefault(x => x.Name == driverName);
            if (driver != null)
            {
                throw new ArgumentException(ExceptionMessages.DriversExists, driverName);
            }

            driver = new Driver(driverName);
            this.drivers.Add(driver);

            return string.Format(OutputMessages.DriverCreated, driverName);

        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar newCar;

            if (cars.Models.FirstOrDefault(x => x.Model == model) != null)
            {
                throw new ArgumentException(ExceptionMessages.CarExists, model);
            }

            if (type == "Muscle")
            {
                newCar = new MuscleCar(model, horsePower);
                cars.Add(newCar);
            }
            else//(type == "Sports")
            {
                newCar = new SportsCar(model, horsePower);
                this.cars.Add(newCar);
            }

            return string.Format(OutputMessages.CarCreated, newCar.GetType().Name , model);

        }

        public string CreateRace(string name, int laps)
        {
            if (races.Models.FirstOrDefault(x => x.Name == name) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }

            var race = new Race(name, laps);

            races.Add(race);

            return string.Format(OutputMessages.RaceCreated, name);

        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            var race = races.Models.FirstOrDefault(x => x.Name == raceName);

            if (race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            IDriver driver = drivers.Models.FirstOrDefault(x => x.Name == driverName);

            if (driver == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            race.AddDriver(driver);
            //races.Add(race);

            return string.Format(OutputMessages.DriverAdded, driverName, raceName);



        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            var driver = drivers.Models.FirstOrDefault(x => x.Name == driverName);

            if (driver == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            var car = cars.Models.FirstOrDefault(x => x.Model == carModel);
            if (car == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }
            
            driver.AddCar(car);
            
            return string.Format(OutputMessages.CarAdded, driverName, carModel);


        }

        public string StartRace(string raceName)
        {

            var race = races.Models.FirstOrDefault(x => x.Name == raceName);

            if (race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }

            var result = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).ToList();

            races.Remove(race);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Driver {result[0].Name} wins { race.Name} race.");
            sb.AppendLine($"Driver {result[1].Name} is second in { race.Name} race.");
            sb.AppendLine($"Driver {result[2].Name} is third in { race.Name} race.");


            return sb.ToString().TrimEnd();

        }
    }
}
