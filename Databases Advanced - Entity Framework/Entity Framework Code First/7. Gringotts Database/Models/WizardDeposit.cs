namespace _7.Gringotts_Database.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class WizardDeposit
    {
        private int age;
        private short magicWandSize;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WizardDeposit(string lastName, int age)
        {
            this.LastName = lastName;
            this.age = age;
            this.DepositStartDate = DateTime.Now;
        }

        public int Id { get; private set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        [Required]
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can not be negative");
                }

                this.age = value;
            }
        }

        [StringLength(100)]
        public string MagicWandCreator { get; set; }

        public short? MagicWandSize
        {
            get
            {
                return this.magicWandSize;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid operation! MagicWandSize must be [1-32767]");
                }
            }
        }

        [StringLength(20)]
        public string DepositGroup { get; set; }

        public DateTime DepositStartDate { get; private set; }

        public decimal? DepositAmount { get; set; }

        public double? DepositInterest { get; set; }

        public decimal? DepositCharge { get; set; }

        public DateTime? DepositExpirationDate { get; set; }

        public bool? IsDepositExpired { get; set; }
    }
}
