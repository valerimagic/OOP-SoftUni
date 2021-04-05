using System;
using System.Collections.Generic;
using System.Text;
using OnlineShop.Common.Enums;
using OnlineShop.Models.Products.Components;

namespace OnlineShop.Models.Products
{
    public class VideoCard : Component
    {
        public VideoCard(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) 
            : base(id, manufacturer, model, price, overallPerformance*1.15, generation)
        {
        }
    }
}
