namespace PhotoShare.Models
{
    using Enumerations;

    public class AlbumRole
    {
        private AlbumRole()
        {
        }

        public AlbumRole(User user, Album album, Role role)
        {
            this.User = user;
            this.Album = album;
            this.Role = role;
        }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AlbumId { get; set; }
        public Album Album { get; set; }

        public Role Role { get; set; }

        public override string ToString()
        {
            return $"{this.User.Username} - {this.Album.Name} - {this.Role}";
        }
    }
}
