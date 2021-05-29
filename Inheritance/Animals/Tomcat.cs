using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        //public string gender = "Male";
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
            //gender = "Male";
        }

        public override string ProduceSound()
        { 
            return "MEOW";
        }
    }
}
