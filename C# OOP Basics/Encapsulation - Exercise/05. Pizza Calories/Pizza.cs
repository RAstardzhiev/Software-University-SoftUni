namespace _05.Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const int NameMaxLength = 15;
        private const int MinToppingsCount = 0;
        private const int MaxToppingsCount = 10;

        private string name;
        private int numberOfToppings;
        private Dough dough;
        private Queue<Topping> toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings;
            this.toppings = new Queue<Topping>();
        }

        public Pizza(string name, int numberOfToppings, Dough dough) : this(name, numberOfToppings)
        {
            this.dough = dough;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > NameMaxLength)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough { set { this.dough = value; } }

        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }

            private set
            {
                if (value < MinToppingsCount || value > MaxToppingsCount)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public string GetTotalCalories()
        {
            var totalCalories = this.dough.GetCalories() + this.toppings.Select(t => t.GetCalories()).Sum();
            return $"{this.Name} - {totalCalories:F2} Calories.";
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Enqueue(topping);
            this.NumberOfToppings = this.toppings.Count;
        }
    }
}
