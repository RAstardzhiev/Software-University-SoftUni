namespace _05.Pizza_Calories
{
    using System;

    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private const int CaloriesPerGram = 2;
        private const double MeatMod = 1.2;
        private const double VeggiesMod = 0.8;
        private const double CheeseMod = 1.1;
        private const double SauceMod = 0.9;

        private string type;
        private int weightInGrams;

        public Topping(string type, int weightInGrams)
        {
            this.Type = type;
            this.WeightInGrams = weightInGrams;
        }

        private int WeightInGrams
        {
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weightInGrams = value;
            }
        }

        private string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && 
                    value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }
        
        internal double GetCalories()
        {
            var calories = 1.0 * this.weightInGrams * CaloriesPerGram;

            switch (this.type.ToLower())
            {
                case "meat":
                    calories *= MeatMod;
                    break;
                case "veggies":
                    calories *= VeggiesMod;
                    break;
                case "cheese":
                    calories *= CheeseMod;
                    break;
                case "sauce":
                    calories *= SauceMod;
                    break;
                default:
                    break;
            }

            return calories;
        }
    }
}
