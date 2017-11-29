namespace PhotoShare.Models
{
    using System.Collections.Generic;
    using Enumerations;

    public class Album
    {
        private ICollection<Picture> pictures;
        private ICollection<AlbumTag> albumTags;
        private ICollection<AlbumRole> albumRoles;

        private Album()
        {
            this.Pictures = new HashSet<Picture>();
            this.AlbumTags = new HashSet<AlbumTag>();
            this.AlbumRoles = new HashSet<AlbumRole>();
        }

        public Album(string name, bool isPublic)
            : this()
        {
            this.Name = name;
            this.IsPublic = isPublic;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Color? BackgroundColor { get; set; }

        public bool IsPublic { get; set; }

        public ICollection<AlbumRole> AlbumRoles
        {
            get { return this.albumRoles; }
            set { this.albumRoles = value; }
        }

        public ICollection<Picture> Pictures
        {
            get { return this.pictures; }
            set { this.pictures = value; }
        }

        public ICollection<AlbumTag> AlbumTags
        {
            get { return this.albumTags; }
            set { this.albumTags = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} has {this.Pictures.Count} pictures";
        }
    }
}
