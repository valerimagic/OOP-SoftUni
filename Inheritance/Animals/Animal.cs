using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        private const string exeptionMessages = "Invalid input!";

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(exeptionMessages);
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(exeptionMessages);
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(exeptionMessages);
                }
                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name)
                .AppendLine($"{this.Name} {this.age} {this.gender}")
                .Append(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }

    }
}
