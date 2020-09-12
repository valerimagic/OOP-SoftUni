using System;
// Клас с индексатор:
class MyClass
{
    // Частно поле, референция към масив:
    private int[] nums;
    // Конструктор с целочислен аргумент:
    public MyClass(int n)
    {
        // Създаване на масив:
        nums = new int[n];
        // Запълване на масива:
        for (int k = 0; k < nums.Length; k++)
        {
            nums[k] = k;
        }
    }
    // Предефиниране на метод ToString():
    public override string ToString()
    {
        // Формиране на текстов низ:
        string txt = "{" + nums[0];
        for (int k = 1; k < nums.Length; k++)
        {
            txt += "," + nums[k];
        }
        txt += "}";
        // Резултат от метода:
        return txt;
    }
    // Целочислено свойство:
    public int length
    {
        // Метод, извикван при четене на свойството:
        get
        {
            // Стойност на свойството:
            return nums.Length;
        }
    }
    // Целочислен индексатор с целочислен индекс:
    public int this[int name]
    {
        // Метод, извикван при четене стойността на
        // обекта с индекс:
        get
        {
            // Стойност на израза:
            return nums[name];
        }
        // Метод, извикван при присвояване на стойност на
        // обекта с индекс:
        set
        {
            // Присвояване на стойност на елемент от масива:
            nums[name] = value;
        }
    }
}
// Клас с главен метод:
class UsingIndexerDemo
{
    // Главен метод:
    static void Main()
    {
        // Създаване на обект:
        MyClass obj = new MyClass(5);
        // Показване съдържанието на масива от обекта:
        Console.WriteLine(obj);
        // Присвояване стойности на елементите от масива от
        // обекта с използване на индексиране:
        for (int k = 0; k < obj.length; k++)
        {
            // Използва се индексиране на обекта:
            obj[k] = 2 * k + 1;
        }
        // Показване съдържанието на масива от обекта:
        Console.WriteLine(obj);
        // Показване на масива от обекта елемент по елемент
        // чрез индексиране на обекта:
        for (int k = 0; k < obj.length; k++)
        {
            // Използва се индексиране на обекта:
            Console.Write(" " + obj[k]);
        }
        Console.WriteLine();
    }
}
