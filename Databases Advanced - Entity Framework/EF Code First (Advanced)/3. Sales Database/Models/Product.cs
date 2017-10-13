namespace _3.Sales_Database.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Helpers;

    public class Product
    {
        private const int NameMaxLength = 50;

        private string name;
        private double quantity;
        private decimal price;
        private string description;
        private DataValidator dataValidator;

        private Product()
        {
            this.dataValidator = new DataValidator();
            this.Sales = new HashSet<Sale>();
        }

        public Product(string name, double quantity, decimal price)
            : this()
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.dataValidator.StringExistenceValidation(value, nameof(Product), nameof(this.Name));
                this.dataValidator.StringMaxLengthValidator(value, NameMaxLength, nameof(this.Name));
                this.name = value;
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
                this.dataValidator.NummericNonNegativeValidation(value, nameof(this.Quantity));
                this.quantity = value;
            }
        }

        [Required]
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.dataValidator.NummericNonNegativeValidation(value, nameof(this.Price));
                this.price = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (value == null)
                {
                    this.description = "No description";
                }
                else
                {
                    this.description = value;
                }
            }
        }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
