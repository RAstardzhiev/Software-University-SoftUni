namespace _05.Pizza_Calories
{
    using System;

    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const int CaloriesPerGram = 2;
        private const double WhiteTypeMod = 1.5;
        private const double CrispyMod = 0.9;
        private const double ChewyMod = 1.1;

        private string flourType;
        private string bakingTechnique;
        private int weightInGrams;

        public Dough(string flourType, string bakingTechnique, int weightInGrams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.WeightInGrams = weightInGrams;
        }

        private int WeightInGrams
        {
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weightInGrams = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public double GetCalories()
        {
            var calories = 1.0 * CaloriesPerGram * this.weightInGrams;

            if (this.flourType.ToLower() == "white")
            {
                calories *= WhiteTypeMod;
            }

            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    calories *= CrispyMod;
                    break;
                case "chewy":
                    calories *= ChewyMod;
                    break;
                default:
                    break;
            }

            return calories;
        }
    }
}
