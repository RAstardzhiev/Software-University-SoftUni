using System.Collections.Generic;

namespace Blog.Models
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }

        public List<Article> NewestArticles { get; set; }

        public List<Article> MostViewedArticles { get; set; }

        public List<Tag> Tags { get; set; }
    }
}