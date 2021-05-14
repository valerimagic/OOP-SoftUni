﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        //public string gender = "Female";


        public Kitten(string name, int age) 
            : base(name, age, "Female")
        {
            //gender = "Female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
        
    }
}