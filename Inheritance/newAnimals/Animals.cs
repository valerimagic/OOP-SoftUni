﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animals
    {
        private string name;
        private int age;
        private string gender;

        public Animals(string name, int age, string gender)
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
                    throw new ArgumentException("Invalid input!");
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
                    throw new ArgumentException("Invalid input!");
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
                    throw new ArgumentException("Invalid input!");
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

            sb.AppendLine($"{this.GetType().Name}")
                .AppendLine($"{ this.Name} {this.Age} {this.Gender}")
                .Append(ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }
}
