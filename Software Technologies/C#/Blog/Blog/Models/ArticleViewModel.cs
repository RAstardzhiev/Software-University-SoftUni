using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [MinLength(300, ErrorMessage = "Article must be at least 300 symbols")]
        public string Content { get; set; }

        public string ImagePath { get; set; }

        public bool DeleteImage { get; set; }

        public string AuthorId { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<Article> Articles { get; set; }

        public IList<Category> Categories { get; set; }

        [Required]
        public string Tags { get; set; }
    }
}