using Blog.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
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
        // GET: Article/Details/Create
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
        // POST: Article/Details/Create
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
    }
}