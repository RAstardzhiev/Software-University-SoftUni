namespace _9.Hospital_Database.Modles
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using _9.Hospital_Database.Modles.Helpers;

    public class Medicament
    {
        private string name;
        private HashSet<Diagnose> diagnoses;

        private DataValidator validator;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicament(string name)
        {
            this.Name = name;
            this.diagnoses = new HashSet<Diagnose>(diagnoses);
            this.validator = new DataValidator();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnose> Diagnoses { get; set; }
    }
}
