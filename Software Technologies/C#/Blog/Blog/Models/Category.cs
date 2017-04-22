using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class Category
    {
        private ICollection<Article> articles;

        public Category()
        {
            this.articles = new HashSet<Article>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(15)]
        [Display(Name = "Category")]
        [RegularExpression(@"^\w+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}