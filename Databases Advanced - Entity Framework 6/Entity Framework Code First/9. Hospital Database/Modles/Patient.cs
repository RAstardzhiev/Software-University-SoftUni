namespace _9.Hospital_Database.Modles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using _9.Hospital_Database.Modles.Helpers;

    public class Patient
    {
        private string firstname;
        private string lastName;
        private string address;
        private string email;
        private string picturePath;

        private DataValidator validator;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient(string firstname, string lastName, string address, DateTime dateOfBirth)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.validator = new DataValidator();
            this.Visitations = new HashSet<Visitation>();
            this.Diagnoses = new HashSet<Diagnose>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName
        {
            get
            {
                return this.firstname;
            }

            set
            {
                this.validator.NullCheck(value);
                this.firstname = value;
            }
        }

        [Required]
        [StringLength(25)]
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
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.validator.NullCheck(value);
                this.address = value;
            }
        }

        [StringLength(70)]
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
        public DateTime DateOfBirth { get; set; }

        public string PicturePath
        {
            get
            {
                return this.picturePath;
            }

            set
            {
                this.validator.NullCheck(value);
                this.picturePath = value;
            }
        }

        [Required]
        public bool IsInsuranceAvailable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitation> Visitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnose> Diagnoses { get; set; }
    }
}
