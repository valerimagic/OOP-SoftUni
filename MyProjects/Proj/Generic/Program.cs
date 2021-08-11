using System;
using Generic.Models;
using Generic.Repo;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericFActory<BMW> bmwRepo = new GenericFActory<BMW>();
            bmwRepo.CableAsembly();
            GenericFActory<Audi> audiRepo = new GenericFActory<Audi>();
            audiRepo.CableAsembly();

            Console.ReadKey(true);


            { 
            }
        }
    }
}
