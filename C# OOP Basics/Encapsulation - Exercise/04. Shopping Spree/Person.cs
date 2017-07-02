namespace _04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Money = money;
            this.Name = name;
            this.Products = new Queue<Product>();
        }

        public Queue<Product> Products { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public void SubstractMoney(decimal amount)
        {
            this.Money -= amount;
        }
    }
}
