namespace _4.Pizza_Calories.Models
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const int CaloriesPerGram = 2;
        private const string InvalidToppingExceptionMessage = "Cannot place {0} on top of your pizza.";
        private const string InvalidWeightExceptionMessage = "{0} weight should be in the range [1..50].";

        private readonly Dictionary<string, double> TypesMods = new Dictionary<string, double>()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            set
            {
                if (!this.TypesMods.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(string.Format(InvalidToppingExceptionMessage, value));
                }

                this.type = value;
            }
        }

        private double Weight
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(string.Format(InvalidWeightExceptionMessage, this.type));
                }

                this.weight = value;
            }
        }

        public double CalculateCalories() => CaloriesPerGram * this.weight * this.TypesMods[this.type.ToLower()];
    }
}
