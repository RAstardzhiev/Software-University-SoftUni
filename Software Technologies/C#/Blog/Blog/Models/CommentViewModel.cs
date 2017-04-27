using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        
        public int ArticleId { get; set; }

        [Required]
        public string Content { get; set; }
        
        public string AuthorId { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorName { get; set; }
    }
}