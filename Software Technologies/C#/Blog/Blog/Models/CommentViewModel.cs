using System;

namespace Blog.Models
{
    public class CommentViewModel
    {
        public int ArticleId { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorId { get; set; }

        public string AuthorName { get; set; }
    }
}