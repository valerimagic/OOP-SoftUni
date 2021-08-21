using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            
        }

        public string FlourType
        {
            get => this.flourType;
            set
            {
                if (value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }

        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double Calculate()
        {
            var calc = (this.Weight * 2) * this.Result(this.BakingTechnique) * 1.5;

            return calc;
        }

        public double Result(string bakingTechnique)
        {

            if (this.BakingTechnique == "Chewy")
            {
                return 1.1;
            }
            else if (this.BakingTechnique == "Crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique == "Homemade")
            {
                return 1.0;
            }


            return 1.0;
        }
    }
}
