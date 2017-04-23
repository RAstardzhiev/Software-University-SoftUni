using Blog.Models;
using System.Linq;
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
    }
}