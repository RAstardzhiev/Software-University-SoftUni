namespace _4.Pizza_Calories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const string InvalidNameExceptionMessage = "Pizza name should be between 1 and 15 symbols.";
        private const string InvalidToppingsNumberExceptionMessage = "Number of toppings should be in range [0..10].";

        private string name;
        private Dough dough;
        private ICollection<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException(InvalidNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public Dough Dough { get => this.dough; set => this.dough = value; }

        public int ToppingsCount => this.toppings.Count;

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count >= 10)
            {
                throw new ArgumentException(InvalidToppingsNumberExceptionMessage);
            }

            this.toppings.Add(topping);
        }

        public double GetCalories()
            => this.Dough.CalculateCalories() + this.toppings.Sum(t => t.CalculateCalories());
    }
}
