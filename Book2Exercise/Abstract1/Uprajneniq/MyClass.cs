using System;
using System.Collections.Generic;
using System.Text;

namespace Uprajneniq
{
    class MyClass
    {
        private int[] nums;


        // Текстово свойство без set-аксесор:
        public string content
        {
            // Метод, извикван при четена стойността на свойството:
            get
            {
                // Ако референцията към масива е празна:
                if (nums == null) 
                    return "{}";
                // Формиране на текстов низ:
                string txt = "{" + nums[0];
                for (int k = 1; k < nums.Length; k++)
                {
                    txt += "," + nums[k];
                }
                txt += "}";
                // Стойност на свойството:
                return txt;
            }
        }
        // Целочислено свойство без get-аксесор:
        public int element
        {
            // Метод, извикван при присвояване стойност на свойството:
            
            set
            {
                // Ако референцията към масива е празна:
                if (nums == null)
                {
                    // Създаване на масив от един елемент:
                    nums = new int[1];
                    // Стойност на единствения елемент на масива:
                    nums[0] = value;
                }
                else
                { // Ако референцията не е празна
                  // Създаване на масив:
                    int[] n = new int[nums.Length + 1];
                    // Запълване на масива:
                    for (int k = 0; k < nums.Length; k++)
                    {
                        n[k] = nums[k];
                    }
                    // Стойност на последния елемент на масива:
                    n[nums.Length] = value;
                    // Референция към създадения масив се записва в
                    // поле на обекта:
                    nums = n;
                }
            }
        }


        // Свойство, явяващо се референция към масив:
        public int[] data
        {
            // Методът, извикван при четене 
            // стойността на свойството:
            get
            {
                // Създаване на масив:
                int[] res = new int[nums.Length];
                // Запълване на масива:
                for (int k = 0; k < nums.Length; k++)
                {
                    res[k] = nums[k];
                }
                // Стойност на свойството:
                return res;
            }
            // Метод, извикван при присвояване на стойност
            // на свойството:
            set
            {
                // Създаване на масив:
                nums = new int[value.Length];
                // Запълване на масива:
                for (int k = 0; k < value.Length; k++)
                {
                    nums[k] = value[k];
                }
            }
        }

    }
}
