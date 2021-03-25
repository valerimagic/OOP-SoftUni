using System;
using System.Collections.Generic;
using System.Text;

namespace CarParking
{
    public class Parking
    {
        private List<Car> cars;
        public Parking()
        {
            cars = new List<Car>();
        }

        //public List<Car> Cars { get; set; }
        public void AddCar(Car car)
        {
            if (this.cars.Count < 10)
            {
                cars.Add(car);
            }
            else
            {
                Console.WriteLine("Parking is full");
            }
        }

        public IReadOnlyCollection<Car> Cars => this.cars;

    }
}
