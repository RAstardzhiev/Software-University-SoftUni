namespace _1.Code_First_Student_System.Models
{
    using System.ComponentModel.DataAnnotations;

    public class License
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
