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
        
        [ForeignKey("Photographer")]
        public int PhotographerOwnerId { get; set; }

        public virtual Photographer Photographer { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
