using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class CommentListViewModel
    {
        [Required]
        public int ArticleId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleAuthorId { get; set; }

        public string ArticleAuthorName { get; set; }

        public DateTime ArticleDate { get; set; }

        public List<Comment> Comments { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }
    }
}