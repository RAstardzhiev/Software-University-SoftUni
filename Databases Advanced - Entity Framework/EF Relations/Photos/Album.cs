namespace Photos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Album
    {
        private Album()
        {
            this.Pictures = new HashSet<Picture>();
            this.Tags = new HashSet<Tag>();
        }

        public Album(string name, string backgroundColor, bool isPublic)
            : this()
        {
            Name = name;
            BackgroundColor = backgroundColor;
            IsPublic = isPublic;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string BackgroundColor { get; set; }

        [Required]
        public bool IsPublic { get; set; }

        public virtual ICollection<Photographer> Photographers { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
