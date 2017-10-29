namespace _4.Pizza_Calories.Models
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private const int CaloriesPerGram = 2;
        private const string InvalidDoughExceptionMessage = "Invalid type of dough.";
        private const string InvalidWeightInGrExceptionMessage = "Dough weight should be in the range [1..200].";

        private readonly Dictionary<string, double> TypesMods = new Dictionary<string, double>
        {
            { "white",  1.5 },
            { "wholegrain", 1.0}
        };

        private readonly Dictionary<string, double> BakingTechniquesMods = new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

        private string type;
        private string bakingTechnique;
        private double weightInGr;

        public Dough(string type, string bakingTechnique, double weightInGr)
        {
            this.Type = type;
            this.BakingTechnique = bakingTechnique;
            this.WeightInGr = weightInGr;
        }

        private string Type
        {
            set
            {
                if (!this.TypesMods.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(InvalidDoughExceptionMessage);
                }

                this.type = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                if (!this.BakingTechniquesMods.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(InvalidDoughExceptionMessage);
                }

                this.bakingTechnique = value;
            }
        }

        private double WeightInGr
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(InvalidWeightInGrExceptionMessage);
                }

                this.weightInGr = value;
            }
        }

        public double CalculateCalories() 
            => CaloriesPerGram * this.weightInGr * this.TypesMods[this.type.ToLower()] * this.BakingTechniquesMods[this.bakingTechnique.ToLower()];
    }
}
