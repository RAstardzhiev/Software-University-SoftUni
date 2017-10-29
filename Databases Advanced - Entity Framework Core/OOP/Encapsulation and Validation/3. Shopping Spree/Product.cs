namespace _3.Shopping_Spree
{
    using System;

    public class Product
    {
        private const string MissingNameExceptionMessage = "Name cannot be empty";
        private const string ZeroOrNegativePriceExceptionMessage = "Price cannot be zero or negative";

        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
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

        public decimal Price
        {
            get => price;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ZeroOrNegativePriceExceptionMessage);
                }

                this.price = value;
            }
        }
    }
}
