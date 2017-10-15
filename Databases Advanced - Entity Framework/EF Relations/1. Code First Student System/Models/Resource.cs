namespace _1.Code_First_Student_System.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        private Resource()
        {
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
        public string Url { get; set; }
    }
}
