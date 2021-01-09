using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const double cubicMuscleCentimeters = 5000;
        private const int minimumHorsePower = 400;
        private const int maximumHorsePower = 600;

        public MuscleCar(string model, int horsePower) 
            : base(model, horsePower, cubicMuscleCentimeters, minimumHorsePower, maximumHorsePower)
        {
        }
    }
}
