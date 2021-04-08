using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Models.Products.Components;
using OnlineShop.Common.Enums;

namespace OnlineShop.Models.Products
{
    public class CentralProcessingUnit : Component
    {
        public CentralProcessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) 
            : base(id, manufacturer, model, price, overallPerformance*1.25, generation)
        {
        }

        
    }
}
