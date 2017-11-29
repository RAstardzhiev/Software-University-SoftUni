namespace PhotoShare.Models
{
    public class AlbumTag
    {
        private AlbumTag()
        {
        }

        public AlbumTag(Album album, Tag Tag)
        {
            this.Album = album;
            this.Tag = Tag;
        }

        public int AlbumId { get; set; }
        public Album Album { get; set; }
        
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
