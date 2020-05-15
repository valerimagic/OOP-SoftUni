using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp

{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tire[] tire)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tire;
           
            
            //this.tires = new KeyValuePair<double, int>[] { KeyValuePair.Create(tire1Pressure, tire1Age), KeyValuePair.Create(tire2Pressure, tire2Age), KeyValuePair.Create(tire3Pressure, tire3age), KeyValuePair.Create(tire4Pressure, tire4age) };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tire { get; set; }
        
        
        //public KeyValuePair<double, int>[] tires;


    }
}
