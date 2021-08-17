using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Repo
{
    public class GenericFActory <T> where T : new ()
    {
        public void CreateBody(T model)
        {
            Console.WriteLine(typeof(T) + "is ccreate a body");
        }

        public void CableAsembly()
        {
            Console.WriteLine(typeof(T) + "is cable asemble ");
        }

        public void Text()
        {
            Console.WriteLine(typeof(T) + "is test");
        }
    }
}
