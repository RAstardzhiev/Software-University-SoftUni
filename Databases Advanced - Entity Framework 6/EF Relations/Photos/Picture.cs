namespace Photos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Picture
    {
        private Picture()
        {
            this.Albums = new HashSet<Album>();
        }

        public Picture(string title, string caption, string path)
            : this()
        {
            Title = title;
            Caption = caption;
            Path = path;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Caption { get; set; }

        [Required]
        [StringLength(100)]
        public string Path { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
