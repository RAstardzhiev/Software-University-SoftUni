using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Blog.Models
{
    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Article> Articles { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Tag> Tags { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}