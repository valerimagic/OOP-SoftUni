using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tire[] tire)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
            this.Tire = tire;
        }

        //model, engine, cargo and a collection of exactly 4 tires

        public string Model { get; set; }
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tire { get; set; }


    }
}
