using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace FactoryMethod
{
    abstract class Factory
    {
        public abstract void Asembling();
        public abstract void testing();
        public abstract void Packaging();
    }
}
