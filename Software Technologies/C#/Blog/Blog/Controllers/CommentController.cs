using Blog.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: Comment/List
        public ActionResult List(int? articleId, int page = 1)
        {
            if (articleId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var article = database.Articles
                    .Where(a => a.Id == articleId)
                    .Include(a => a.Author)
                    .FirstOrDefault();

                if (article == null)
                {
                    return HttpNotFound();
                }

                // Set the paging
                if (page < 1)
                {
                    page = 1;
                }

                var pageSize = 2;

                var comments = article.Comments
                    .OrderByDescending(c => c.DateCreated)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                var model = new CommentListViewModel()
                {
                    ArticleAuthorId = article.AuthorId,
                    ArticleAuthorName = article.Author.FullName,
                    ArticleDate = article.DateCreated,
                    ArticleId = article.Id,
                    ArticleTitle = article.Title,
                    Comments = comments,
                    CurrentPage = page,
                    PagesCount = (int)Math.Ceiling(article.Comments.Count * 1.0 / pageSize)
                };

                return View(model);
            }
        }

        //
        // GET: Comment/Create
        [Authorize]
        [HttpGet]
        public ActionResult Create(int id)
        {
            // Create view model
            var model = new CommentViewModel { ArticleId = id };

            // Return view
            return View(model);
        }

        //
        // POST: Comment/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    var article = database.Articles.Where(a => a.Id == model.ArticleId);

                    if (article != null)
                    {
                        var authorId = User.Identity.GetUserId();

                        var comment = new Comment(authorId, model.ArticleId, model.Content);

                        database.Comments.Add(comment);
                        database.SaveChanges();
                    }
                }

                return RedirectToAction("Details", "Article", new { id = model.ArticleId });
            }

            return View(model);
        }

        //
        // GET: Comment/Edit
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Get comment from database
            var comment = new BlogDbContext().Comments
                .Where(c => c.Id == id)
                .FirstOrDefault();

            // Check if there is such a comment
            if (comment == null)
            {
                return HttpNotFound();
            }

            // Check user permissions
            if (!comment.AuthorId.Equals(User.Identity.GetUserId()) && !User.IsInRole("Admin"))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            // Create view model
            var model = new CommentViewModel();
            model.Id = comment.Id;
            model.Content = comment.Content;
            model.ArticleId = comment.ArticleId;

            return View(model);
        }

        //
        // POST: Comment/Edit
        [Authorize]
        [HttpPost]
        public ActionResult Edit(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    var comment = database.Comments
                    .Where(c => c.Id == model.Id)
                    .FirstOrDefault();

                    comment.Content = model.Content;

                    database.Entry(comment).State = EntityState.Modified;
                    database.SaveChanges();

                    return RedirectToAction("Details", "Article", new { @id = comment.ArticleId });
                }
            }

            return View(model);
        }

        //
        // GET: Comment/Delete
        [Authorize]
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Get comment from database
            var comment = new BlogDbContext().Comments
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (comment == null)
            {
                return HttpNotFound();
            }

            // Check user permissions
            if (!comment.AuthorId.Equals(User.Identity.GetUserId()) && !User.IsInRole("Admin"))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            // Create model
            var model = new CommentViewModel();
            model.Id = comment.Id;
            model.ArticleId = comment.ArticleId;
            model.Content = comment.Content;

            // Return view
            return View(model);
        }

        //
        // POST: Comment/Delete
        [Authorize]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                // Get comment from database
                var comment = database.Comments
                    .Where(c => c.Id == id)
                    .FirstOrDefault();

                // Check if comment exists
                if (comment == null)
                {
                    return HttpNotFound();
                }

                // Get id of the article to which will return
                int articleId = comment.ArticleId;

                // Remove comment from database
                database.Comments.Remove(comment);
                database.SaveChanges();

                return RedirectToAction("Details", "Article", new { id = articleId });
            }
        }
    }
}