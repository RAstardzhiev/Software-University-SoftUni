namespace _1.Local_Store.Modedls
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Product
    {
        private const string MissingStringExceptionMessage = "{0} must not be empty";
        private const string ExceedingStringLengthExceptionMessage = "{0} must be no more then {1} symbols";
        private const string NegativeNumberExceptionMessage = "Invalid numbver {0}. {1} cannot be less than zero";
        private const int NamesMaxLength = 50;

        private string name;
        private string distributorName;
        private decimal price;
        private double weight;
        private double quantity;

        private Product()
        {
        }

        public Product(string name, string distributorName, decimal price, double quantity)
        {
            this.Name = name;
            this.DistributorName = distributorName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(NamesMaxLength)]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.ValidateStringExistance(value, nameof(Name));
                this.ValidateStringLength(value, NamesMaxLength, nameof(Name));

                this.name = value;
            }
        }

        [Required]
        [StringLength(NamesMaxLength)]
        public string DistributorName
        {
            get
            {
                return this.distributorName;
            }

            set
            {
                this.ValidateStringExistance(value, nameof(DistributorName));
                this.ValidateStringLength(value, NamesMaxLength, nameof(DistributorName));

                this.distributorName = value;
            }
        }
        
        public string Description { get; set; }

        [Required]
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(NegativeNumberExceptionMessage, value, nameof(Price)));
                }

                this.price = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(NegativeNumberExceptionMessage, value, nameof(Weight)));
                }

                this.weight = value;
            }
        }

        [Required]
        public double Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(NegativeNumberExceptionMessage, value, nameof(Quantity)));
                }

                this.quantity = value;
            }
        }

        private void ValidateStringLength(string value, int maxLength, string propName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(string.Format(ExceedingStringLengthExceptionMessage, propName, maxLength));
            }
        }

        private void ValidateStringExistance(string value, string propName)
        {
            if (string.IsNullOrWhiteSpace(value) && !DBNull.Value.Equals(value))
            {
                throw new ArgumentException(string.Format(MissingStringExceptionMessage, propName));
            }
        }

        public override string ToString()
        {
            var upDownClosingLine = new string('-', 43);
            var lineSeparator = $"|{new string('-', 20)}+{new string('-', 20)}|";

            var sb = new StringBuilder();
            sb.AppendLine(upDownClosingLine)
                .AppendLine($"| {nameof(this.Name), -19}| {this.Name, -19}|")
                .AppendLine(lineSeparator)
                .AppendLine($"| {nameof(this.DistributorName),-19}| {this.DistributorName, -19}|")
                .AppendLine(lineSeparator)
                .AppendLine($"| {nameof(this.Quantity), -19}| {this.Quantity, -19}|")
                .AppendLine(lineSeparator)
                .AppendLine($"| {nameof(this.Price), -19}| {this.Price, -19}|")
                .AppendLine(upDownClosingLine);

            return sb.ToString();
        }
    }
}
