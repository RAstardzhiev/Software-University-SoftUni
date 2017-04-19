using Blog.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class TagController : Controller
    {
        //
        //GET: Tag
        public ActionResult Index()
        {
            return RedirectToAction("All");
        }

        public ActionResult All()
        {
            using (var database = new BlogDbContext())
            {
                var tags = database.Tags.ToArray();
                if (tags == null)
                {
                    return HttpNotFound();
                }

                return View(tags);
            }
        }

        //
        // GET: Tag/List
        public ActionResult List(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                // Get articles from database
                var articles = database.Tags
                    .Include(t => t.Articles.Select(a => a.Tags))
                    .Include(t => t.Articles.Select(a => a.Author))
                    .FirstOrDefault(t => t.Id == id)
                    .Articles
                    .ToList();

                // Return the view
                return View(articles);
            }
        }
    }
}