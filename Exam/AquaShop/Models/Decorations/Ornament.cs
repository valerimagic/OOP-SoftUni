using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int OrnamentConfort = 1;
        private const decimal OrnamentPrice = 5;

        public Ornament() 
            : base(OrnamentConfort, OrnamentPrice)
        {

        }
    }
}
