using ClasBoxData;
using System;

namespace Encapsulation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lengthA = double.Parse(Console.ReadLine());
            var widthA = double.Parse(Console.ReadLine());
            var heightA = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(lengthA, widthA, heightA);

                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");

            }

            catch(ArgumentException message)
            {
                Console.WriteLine(message.Message);
            }

        }
    }
}
