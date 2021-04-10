﻿using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Common.Enums;

namespace OnlineShop.Models.Products.Components
{
    public abstract class Component : Product, IComponent
    {
        
        protected Component(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.Generation = generation;
        }

        public int Generation  { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $" Generation: {this.Generation}";
        }
    }
}
