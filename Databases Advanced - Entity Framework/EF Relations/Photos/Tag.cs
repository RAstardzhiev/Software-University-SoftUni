namespace Photos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
        private string name;

        private Tag()
        {
        }

        public Tag(string name)
        {
            Name = name;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
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
