namespace _1.Code_First_Student_System.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Resource
    {
        private Resource()
        {
            this.Licenses = new HashSet<License>();
        }

        public Resource(string name, string resourceType, string url)
        {
            this.Name = name;
            this.ResourceType = resourceType;
            this.Url = url;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string ResourceType { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Url { get; set; }

        public virtual ICollection<License> Licenses { get; set; }
    }
}
