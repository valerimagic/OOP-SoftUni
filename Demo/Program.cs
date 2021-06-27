using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            factoriel(input);
        }

        static int factoriel(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int result = n * factoriel(n - 1);
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
