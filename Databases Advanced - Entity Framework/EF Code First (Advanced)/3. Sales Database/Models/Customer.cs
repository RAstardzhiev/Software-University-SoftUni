namespace _3.Sales_Database.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Helpers;

    public class Customer
    {
        private const int NameMaxLength = 50;
        private const int EmailMaxLength = 100;
        private const int CreditCardNumberExactLength = 16;

        private string name;
        private string email;
        private string creditCardNumber;
        private DataValidator dataValidator;

        private Customer()
        {
            this.dataValidator = new DataValidator();
            this.Sales = new HashSet<Sale>();
        }

        public Customer(string name, string email)
            : this()
        {
            this.Name = name;
            this.Email = email;
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
                this.dataValidator.StringExistenceValidation(value, nameof(Customer), nameof(this.Name));
                this.dataValidator.StringMaxLengthValidator(value, NameMaxLength, nameof(this.Name));
                this.name = value;
            }
        }

        [Required]
        [StringLength(EmailMaxLength)]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.dataValidator.StringExistenceValidation(value, nameof(Customer), nameof(this.Email));
                this.dataValidator.StringMaxLengthValidator(value, EmailMaxLength, nameof(this.Email));
                this.email = value;
            }
        }

        [MinLength(CreditCardNumberExactLength)]
        [MaxLength(CreditCardNumberExactLength)]
        [Display(Name = "Credit Card Number")]
        public string CreditCardNumber
        {
            get
            {
                return this.creditCardNumber;
            }

            set
            {
                this.dataValidator.StringMaxLengthValidator(value, CreditCardNumberExactLength, nameof(this.CreditCardNumber));
                this.dataValidator.StringMinLengthValidator(value, CreditCardNumberExactLength, nameof(this.CreditCardNumber));
                this.creditCardNumber = value;
            }
        }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
