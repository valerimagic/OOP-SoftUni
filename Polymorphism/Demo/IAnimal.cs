using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public interface IAnimal
    {
        IEnumerable<IAnimal> Children { get; }

        public string SayHello();

        public string Valeri();

    }
}
