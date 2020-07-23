using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Exception2

{
    public class UneateableFoodException : Exception
    {

        private const string Def_Exc_Msg = "{AnimalType} does not eat {FoodType}!";
        public UneateableFoodException()
        {
        }

        public UneateableFoodException(string message) : base(message)
        {
        }
    }
}
