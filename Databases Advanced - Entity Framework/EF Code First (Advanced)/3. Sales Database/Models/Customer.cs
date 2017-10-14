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

        private string firstName;
        private string lastName;
        private string email;
        private string creditCardNumber;
        private DataValidator dataValidator;

        private Customer()
        {
            this.dataValidator = new DataValidator();
            this.Sales = new HashSet<Sale>();
        }

        public Customer(string name, string lastName, string email)
            : this()
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Email = email;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.dataValidator.StringExistenceValidation(value, nameof(Customer), nameof(this.FirstName));
                this.dataValidator.StringMaxLengthValidator(value, NameMaxLength, nameof(this.FirstName));
                this.firstName = value;
            }
        }

        [Required]
        [StringLength(NameMaxLength)]
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.dataValidator.StringExistenceValidation(value, nameof(Customer), nameof(this.LastName));
                this.dataValidator.StringMaxLengthValidator(value, NameMaxLength, nameof(this.LastName));
                this.lastName = value;
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
