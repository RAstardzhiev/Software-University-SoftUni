using Blog.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: Category
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        //
        // GET: Category/List
        public ActionResult List()
        {
            using (var database = new BlogDbContext())
            {
                var categories = database.Categories.Include(c => c.Articles).ToList();

                return View(categories);
            }
        }

        //
        // GET: Category/Create
        [Authorize]
        public ActionResult Create()
        {
            if (!IsAdmin())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            return View();
        }

        //
        // POST: Category/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Category category)
        {
            if (!IsAdmin())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    database.Categories.Add(category);
                    database.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(category);
        }

        //
        // GET: Category/Edit
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (!IsAdmin())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            using (var database = new BlogDbContext())
            {
                var category = database.Categories.FirstOrDefault(c => c.Id == id);

                if (category == null)
                {
                    return HttpNotFound();
                }

                return View(category);
            }
        }

        //
        // POST: Category/Edit
        [Authorize]
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (!IsAdmin())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    database.Entry(category).State = EntityState.Modified;
                    database.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(category);
        }

        //
        // GET: Category/Delete
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (!IsAdmin())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            using (var database = new BlogDbContext())
            {
                var category = database.Categories.FirstOrDefault(c => c.Id == id);

                if (category == null)
                {
                    return HttpNotFound();
                }

                return View(category);
            }
        }

        //
        // POST: Category/Delete
        [Authorize]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (!IsAdmin())
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            using (var database = new BlogDbContext())
            {
                var category = database.Categories.FirstOrDefault(c => c.Id == id);
                var categoryArticles = database.Articles.ToList();

                foreach (var article in categoryArticles)
                {
                    database.Articles.Remove(article);
                }

                database.Categories.Remove(category);

                database.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public bool IsAdmin()
        {
            return this.User.IsInRole("Admin");
        }
    }
}