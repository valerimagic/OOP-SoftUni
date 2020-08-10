using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Cat : Mammal, IAnimal
    {
        public IEnumerable<IAnimal> Children { get; } = new List<IAnimal>();

        public string SayHello()
        {
            return "Zdr!";
        }

        public string Valeri()
        {
            throw new NotImplementedException();
        }

        public int MiceKilled { get; private set; } = 10000;

        
    }
}
