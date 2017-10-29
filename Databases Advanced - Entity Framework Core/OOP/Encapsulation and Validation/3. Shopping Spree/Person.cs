namespace _3.Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private const string MissingNameExceptionMessage = "Name cannot be empty";
        private const string NegativeMoneyExceptionMesage = "Money cannot be negative";

        private string name;
        private decimal money;
        private ICollection<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(MissingNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => money;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(NegativeMoneyExceptionMesage);
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts { get => this.bagOfProducts as IReadOnlyCollection<Product>; }
        
        public void BuyProduct(Product product)
        {
            this.Money -= product.Price;
            this.bagOfProducts.Add(product);
        }
    }
}
