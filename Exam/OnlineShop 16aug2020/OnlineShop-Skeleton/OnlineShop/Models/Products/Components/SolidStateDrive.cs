using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Common.Enums;
using OnlineShop.Models.Products.Components;

namespace OnlineShop.Models.Products
{
    public class SolidStateDrive : Component
    {
        public SolidStateDrive(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) 
            : base(id, manufacturer, model, price, overallPerformance*1.20, generation)
        {
        }
    }
}
