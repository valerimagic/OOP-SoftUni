using System;

namespace Uprajneniq
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            // Проверка на съдържанието на масива от обекта:
            Console.WriteLine(obj.content);
            // Присвояване на стойност на свойство element:
            obj.element = 10;
            // Проверка на съдържанието на масива от обекта:
            Console.WriteLine(obj.content);
            // Присвояване на стойност на свойството element:
            obj.element = 5;
            obj.element = 7;
            // Проверка на съдържанието на масива от обекта:
            Console.WriteLine(obj.content);
            // Четене на стойността на свойство data:
            int[] A = obj.data;
            // Присвояване на стойност на свойство element:
            obj.element = 12;
            // Показване съдържанието на масив A:
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write(A[k] + " ");
            }
            Console.WriteLine();
            // Проверка на съдържанието на масива от обекта:
            Console.WriteLine(obj.content);
            // Създаване на масив:
            int[] B = { 11, 3, 6 };
            // Присвояване на стойност на свойството data:
            obj.data = B;
            // Промяна на стойността на елемент от масив B:
            B[0] = 0;
            // Показване съдържанието на масив B:
            for (int k = 0; k < B.Length; k++)
            {
                Console.Write(B[k] + " ");
            }
            Console.WriteLine();
            // Проверка на съдържанието на масива от обекта:
            Console.WriteLine(obj.content);

        }
    }
}
