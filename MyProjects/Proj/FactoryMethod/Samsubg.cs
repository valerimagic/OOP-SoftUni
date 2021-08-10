using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Samsubg : Factory
    {
        public override void Asembling()
        {
            Console.WriteLine("samsubg ");
        }

        public override void testing()
        {
            Console.WriteLine("samsubg testing");
        }

        public override void Packaging()
        {
            Console.WriteLine("samsubg pack");
        }
    }
}
