using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");

                }

                this.age = value;
            }
        }
        public string Gender { get; set; }


        public virtual string ProduceSound()
        {
            return ToString();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(GetType().Name)
                .AppendLine($"{Name} {Age} {Gender}")
                .AppendLine(ProduceSound());

            return sb.ToString().TrimEnd();

            
        }
    }
}
