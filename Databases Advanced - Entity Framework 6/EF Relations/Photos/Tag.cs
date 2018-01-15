namespace Photos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
        private string name;

        private Tag()
        {
            this.Albums = new HashSet<Album>();
        }

        public Tag(string name)
            : this()
        {
            Name = name;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value
                    .Replace(" ", string.Empty)
                    .Replace("\t", string.Empty);
            }
        }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
