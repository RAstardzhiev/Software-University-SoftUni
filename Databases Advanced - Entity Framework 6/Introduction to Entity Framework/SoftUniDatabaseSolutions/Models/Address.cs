namespace Introduction_to_Entity_Framework.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Employees = new HashSet<Employee>();
        }

        public int AddressID { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressText { get; set; }

        public int? TownID { get; set; }

        public virtual Town Town { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
