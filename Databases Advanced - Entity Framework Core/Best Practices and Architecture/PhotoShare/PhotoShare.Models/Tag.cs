namespace PhotoShare.Models
{
    using System.Collections.Generic;

    using PhotoShare.Models.Validation;

    public class Tag
    {
        private Tag()
        {
            this.AlbumTags = new HashSet<AlbumTag>();
        }

        public Tag(string name)
            : this()
        {
            this.Name = name;
        }

        public int Id { get; set; }

        [Tag]
        public string Name { get; set; }

        public ICollection<AlbumTag> AlbumTags { get; set; }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
