using ShoppingSpree.Common;
using System;
using System.Collections.Generic;

using System.Text;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private const decimal cosMinValue = 0;

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
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

        public decimal Cost
        {
            get
            {
                return this.cost;
            }

            set
            {
                if (value < cosMinValue)
                {
                    throw new ArgumentException(Constrain.moneyCannotBeNegative);
                }
                this.cost = value;
            }
        }

    }
}
