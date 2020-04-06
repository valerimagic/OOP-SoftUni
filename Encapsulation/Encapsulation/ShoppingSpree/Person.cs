using ShoppingSpree.Common;
using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Constrain.nameCannotBeEmpty);
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(Constrain.moneyCannotBeNegative);
                }
                this.money = value;
            }
        }

        public void Buy(Product product)
        {
            if(product.Cost > this.money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
            this.bag.Add(product);
            this.money -= product.Cost;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        



    }
}
