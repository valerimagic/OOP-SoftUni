using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car
    {
        private const double cubicSportCentimeters = 3000;
        private const int minimumHorsePower = 250;
        private const int maximumHorsePower = 450;

        public SportsCar(string model, int horsePower) 
            : base(model, horsePower, cubicSportCentimeters, minimumHorsePower, maximumHorsePower)
        {

        }
    }
}
