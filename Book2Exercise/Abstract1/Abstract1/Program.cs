using System;

namespace Abstract1
{
    class Program
    {


        // Абстрактен клас:
        abstract class Base
        {
            // Защитено целочислено поле:
            protected int num;


            public Base(int n)                // Конструктор:
            {
                set(n);                       // Извикване на метод:
            }

            // Абстрактни методи:
            public abstract void show();

            public abstract void set(int n);

            public abstract int get();

        }


        // Производен клас на основата на абстрактен:
        class Alpha : Base
        {

            protected int val;          // Защитено целочислено поле:

            public Alpha(int n)           // Конструктор:
               : base(n)
            {
                show();                   // Извикване на метод:
            }


            public override void show()          // Предефиниране на абстрактен метод:
            {

                Console.WriteLine("Alpha: {0}, {1} и {2}", num, val, get());                // Извеждане на съобщение:
            }

            public override void set(int n)             // Предефиниране на абстрактен метод:
            {
                // Присвояване на стойности на полетата:
                num = n;
                val = n % 10;
            }

            public override int get()                 // Предефиниране на абстрактен метод:
            {
                return num / 10;
            }
        }
        // Производен клас на основата на абстрактен:
        class Bravo : Base
        {
            // Защитено целочислено поле:
            protected int val;
            // Конструктор:
            public Bravo(int n) : base(n)
            {
                // Извикване на метод:
                show();
            }
            // Предефиниране на абстрактен метод:
            public override void show()
            {
                // Извеждане на съобщение:
                Console.WriteLine("Bravo: {0}, {1} и {2}", num, val, get());
            }
            // Предефиниране на абстрактен метод:
            public override void set(int n)
            {
                // Присвояване на стойности на полетата:
                num = n;
                val = n % 100;
            }
            // Предефиниране на абстрактен метод:
            public override int get()
            {
                return num / 100;
            }
        }
        // Клас с главен метод:
        class AbstractDemo
        {
            // Главен метод:
            static void Main()
            {
                // Обектна променлива на абстрактен клас:
                Base obj;
                // Създаване на обекти на производните класове:
                Alpha A = new Alpha(123);
                Bravo B = new Bravo(321);
                // На обектна променлива на базов клас се 
                // присвоява референция към обект на производен:
                obj = A;
                Console.WriteLine("Sled izpylnenie na programata obj=A");
                // Извикване на методите чрез обектна променлива на
                // базовия клас:
                obj.set(456);
                obj.show();
                // На обектна променлива на базов клас се 
                // присвоява референция към обект на производен:
                obj = B;
                Console.WriteLine("Sled izpylnenie na komandata obj=B");
                // Извикване на методите чрез обектна променлива на
                // базовия клас:
                obj.set(654);
                obj.show();
            }
        }

    }

}


