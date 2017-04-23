using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Blog.Models
{
    public class Comment
    {
        private ICollection<Article> articles;

        public Comment()
        {
        }

        public Comment(string authirId, int articleId, string content)
        {
            using (var databasse = new BlogDbContext())
            {
                this.AuthorId = authirId;
                this.DateCreated = DateTime.Now;
                this.ArticleId = articleId;
                this.Content = content;
                this.AuthorName = databasse.Users
                                .Where(u => u.Id.Equals(AuthorId))
                                .First()
                                .FullName;
                this.AuthorUserName = databasse.Users
                                .Where(u => u.Id.Equals(AuthorId))
                                .First()
                                .UserName;
            }
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public string AuthorName { get; set; }

        public string AuthorUserName { get; set; }

        public int ArticleId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }
    }
}