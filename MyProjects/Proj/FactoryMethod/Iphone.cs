using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Iphone : Factory
    {
        public override void Asembling()
        {
            Console.WriteLine("Iphone");
        }

        public override void testing()
        {
            Console.WriteLine("Iphone testing");
        }

        public override void Packaging()
        {
            Console.WriteLine("Iphone pack");
        }
    }
}
