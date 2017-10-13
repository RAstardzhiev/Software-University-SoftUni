namespace _3.Sales_Database.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Helpers;

    public class Sale
    {
        private int productId;
        private int customerId;
        private int storeLocationId;
        private DataValidator dataValidator;

        private Sale()
        {
            this.dataValidator = new DataValidator();
        }

        public Sale(int productId, int customerId, int storeLocationId, DateTime date) 
            : this()
        {
            this.ProductId = productId;
            this.CustomerId = customerId;
            this.StoreLocationId = storeLocationId;
            this.Date = date;
        }

        public Sale(int productId, int customerId, int storeLocationId) 
            : this(productId, customerId, storeLocationId, DateTime.Now)
        {
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Id")]
        public int ProductId
        {
            get
            {
                return this.productId;
            }

            set
            {
                this.dataValidator.IdGreaterThanZeroValidation(value);
                this.productId = value;
            }
        }

        [Required]
        [Display(Name = "Customer Id")]
        public int CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.dataValidator.IdGreaterThanZeroValidation(value);
                this.customerId = value;
            }
        }

        [Required]
        [Display(Name = "Store Location Id")]
        public int StoreLocationId
        {
            get
            {
                return this.storeLocationId;
            }

            set
            {
                this.dataValidator.IdGreaterThanZeroValidation(value);
                this.storeLocationId = value;
            }
        }

        [Required]
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual StoreLocation StoreLocation { get; set; }
    }
}
