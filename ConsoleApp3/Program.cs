using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new [] {1, 2, 3, 4, 5};

            Console.WriteLine(SumArray(array, 0));
        }


        private static int SumArray(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

             return array[index] + SumArray(array, index + 1);    // сумираме текущия индекс със подмасива който имаме
        }

    }
}
