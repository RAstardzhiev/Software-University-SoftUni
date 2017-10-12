namespace _1.Local_Store.Modedls
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class OldProduct
    {
        private const string MissingStringExceptionMessage = "{0} must not be empty";
        private const string ExceedingStringLengthExceptionMessage = "{0} must be no more then {1} symbols";
        private const string NegativePriceExceptionMessage = "Invalid price {0}. Price cannot be less than zero";
        private const int NamesMaxLength = 50;

        private string name;
        private string distributorName;
        private decimal price;

        private OldProduct()
        {
        }

        public OldProduct(string name, string distributorName, decimal price)
        {
            this.Name = name;
            this.DistributorName = distributorName;
            this.Price = price;
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
                this.ValidateStringExistance(value, nameof(Name));
                this.ValidateStringLength(value, NamesMaxLength, nameof(Name));

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
                    throw new ArgumentException(string.Format(NegativePriceExceptionMessage, value));
                }

                this.price = value;
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
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(MissingStringExceptionMessage, propName));
            }
        }
    }
}
