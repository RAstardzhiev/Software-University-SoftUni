using System.Collections.Generic;

namespace Blog.Models
{
    public class ArticleListViewModel
    {
        public List<Article> Articles { get; set; }

        public int CurrentPage { get; set; }

        public int FirstPostOnPage { get; set; }

        public int LastPostOnPage { get; set; }

        public int TotalPostsCount { get; set; }

        public int PagesCount { get; set; }

        public int PageSize { get; set; }

        public string FilterArgs { get; set; }
    }
}