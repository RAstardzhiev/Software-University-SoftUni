namespace _9.Hospital_Database.Modles
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using _9.Hospital_Database.Modles.Helpers;

    public class Doctor
    {
        private string firstName;
        private string lastName;
        private string specialty;
        private string password;
        private string email;

        private DataValidator validator;

        public Doctor(string firstName, string lastName, string specialty, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Specialty = specialty;
            this.Password = password;

            this.validator = new DataValidator();
            this.Visitations = new HashSet<Visitation>();
            this.Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.validator.NullCheck(value);
                this.firstName = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.validator.NullCheck(value);
                this.lastName = value;
            }
        }

        [Required]
        [StringLength(100)]
        public string Specialty
        {
            get
            {
                return this.specialty;
            }

            set
            {
                this.validator.NullCheck(value);
                this.specialty = value;
            }
        }

        [StringLength(100)]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.validator.NullCheck(value);
                this.email = value;
            }
        }

        [Required]
        [MinLength(8)]
        [MaxLength(16)]
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.validator.NullCheck(value);
                this.validator.PasswordValidation(value);
                this.password = value;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitation> Visitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
