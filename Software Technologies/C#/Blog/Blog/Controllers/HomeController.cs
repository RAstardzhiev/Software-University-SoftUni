using Blog.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var database = new BlogDbContext();
            var articles = database.Articles.ToList();
            var model = new HomeViewModel();

            model.NewestArticles = articles
                .OrderByDescending(a => a.DateCreated)
                .Take(2)
                .ToList();

            model.MostViewedArticles = articles
                .OrderByDescending(a => a.Visits)
                .Take(2)
                .ToList();

            model.Categories = database.Categories
                .OrderByDescending(c => c.Articles.Count)
                .ThenBy(c => c.Name)
                .Take(5)
                .ToList();

            model.Tags = database.Tags
                .OrderByDescending(t => t.Articles.Count)
                .ThenBy(t => t.Name)
                .Take(5)
                .ToList();

            return View(model);
        }

        public ActionResult ListCategories()
        {
            using (var database  = new BlogDbContext())
            {
                var categories = database.Categories
                    .Include(c => c.Articles)
                    .OrderBy(c => c.Name)
                    .ToList();

                return View(categories);
            }
        }
    }
}