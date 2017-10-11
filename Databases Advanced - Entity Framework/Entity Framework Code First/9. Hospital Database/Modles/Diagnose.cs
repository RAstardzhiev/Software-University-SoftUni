namespace _9.Hospital_Database.Modles
{
    using _9.Hospital_Database.Modles.Helpers;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Diagnose
    {
        private string name;
        private string comments;

        private DataValidator validator;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnose(string name, string comments)
            : this(name)
        {
            this.Comments = comments;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnose(string name)
        {
            this.Name = name;
            this.validator = new DataValidator();
            this.Medicaments = new HashSet<Medicament>();
            this.Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.validator.NullCheck(value);
                this.name = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                this.validator.NullCheck(value);
                this.comments = value;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicament> Medicaments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> DoctorsAssigningThisDiagnose { get; set; }
    }
}