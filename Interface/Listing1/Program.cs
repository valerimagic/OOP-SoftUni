using System;
// Абстрактен клас:
abstract class Base
{
    // Защитено целочислено поле:
    protected int num;

    
    public Base(int n)   // Конструктор:
    {
        
        set(n);     // Извикване на метод:
    }
    // Абстрактни методи:
    public abstract void show();

    public abstract void set(int n);

    public abstract int get();

}
// Производен клас на основата на абстрактен:
class Alpha : Base
{
    // Защитено целочислено поле:
    protected int val;
    // Конструктор:
    public Alpha(int n) 
        : base(n)
    {
        
        show();      // Извикване на метод:
    }

    // Предефиниране на абстрактен метод:
    public override void show()
    {
        // Извеждане на съобщение:
        Console.WriteLine("Alpha: {0}, {1} и {2}", num, val, get());
    }
    // Предефиниране на абстрактен метод:
    public override void set(int n)
    {
        // Присвояване на стойности на полетата:
        num = n;
        val = n % 10;
    }
    // Предефиниране на абстрактен метод:
    public override int get()
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
        Console.WriteLine("След изпълнение на командата obj=A");
        // Извикване на методите чрез обектна променлива на
        // базовия клас:
        obj.set(456);
        obj.show();
        // На обектна променлива на базов клас се 
        // присвоява референция към обект на производен:
        obj = B;
        Console.WriteLine("След изпълнение на командата obj=B");
        // Извикване на методите чрез обектна променлива на
        // базовия клас:
        obj.set(654);
        obj.show();
    }
}
