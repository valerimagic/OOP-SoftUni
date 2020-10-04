using System;

namespace Problem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());


            try
            {
                var box = new Box(a, b, c);
                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.GetVolume():F2}");

            }
            catch (ArgumentException messages)
            {

                Console.WriteLine(messages.Message);
            }



        }
    }
}
