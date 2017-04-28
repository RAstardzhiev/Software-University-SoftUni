using Blog.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;

namespace Blog.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        //
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        //
        // GET: User/List
        public ActionResult List()
        {
            using (var database = new BlogDbContext())
            {
                var users = database.Users.ToList();

                var admins = GetAdminUserNames(users, database);
                ViewBag.Admins = admins;

                return View(users);
            }
        }

        private HashSet<string> GetAdminUserNames(List<ApplicationUser> users, BlogDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var admins = new HashSet<string>();

            foreach (var user in users)
            {
                if (userManager.IsInRole(user.Id, "Admin"))
                {
                    admins.Add(user.UserName);
                }
            }

            return admins;
        }

        //
        // GET: User/Edit
        public ActionResult Edit(string id)
        {
            // Validate id
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                // Get user from database
                var user = database.Users.Where(u => u.Id == id).First();


                // Check if user exists
                if (user == null)
                {
                    return HttpNotFound();
                }

                // Create a view model
                var viewModel = new EditUserViewModel();
                viewModel.User = user;
                viewModel.Roles = GetUserRoles(user, database);

                // Pass the model to the view
                return View(viewModel);
            }
        }

        private IList<Role> GetUserRoles(ApplicationUser user, BlogDbContext database)
        {
            // Create user manager
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();

            // Get all application roles
            var roles = database.Roles
                .Select(r => r.Name)
                .OrderBy(r => r)
                .ToList();

            // For each application role, check if the user has it
            var userRoles = new List<Role>();

            foreach (var roleName in roles)
            {
                var role = new Role { Name = roleName };

                if (userManager.IsInRole(user.Id, roleName))
                {
                    role.IsSelected = true;
                }

                userRoles.Add(role);
            }

            // Return a list with all roles
            return userRoles;
        }

        //
        // POST: User/Edit
        [HttpPost]
        public ActionResult Edit(string id, EditUserViewModel viewModel)
        {
            // Check if model is valid
            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    // Get user from database
                    var user = database.Users.FirstOrDefault(u => u.Id == id);

                    // check if user exists
                    if (user == null)
                    {
                        return HttpNotFound();
                    }

                    // If password field is not empty, check password
                    if (!string.IsNullOrEmpty(viewModel.Password))
                    {
                        var hasher = new PasswordHasher();
                        var passwordHasher = hasher.HashPassword(viewModel.Password);
                        user.PasswordHash = passwordHasher;
                    }

                    // Set user properties
                    user.Email = viewModel.User.Email;
                    user.UserName = viewModel.User.Email;
                    user.FullName = viewModel.User.FullName;
                    this.SetUserRoles(viewModel, user, database);

                    // Save changes
                    database.Entry(user).State = EntityState.Modified;
                    database.SaveChanges();

                    return RedirectToAction("List");
                }
            }

            return View(viewModel);
        }

        private void SetUserRoles(EditUserViewModel viewModel, ApplicationUser user, BlogDbContext database)
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();

            foreach (var role in viewModel.Roles)
            {
                if (role.IsSelected)
                {
                    userManager.AddToRole(user.Id, role.Name);
                }
                else if (!role.IsSelected)
                {
                    userManager.RemoveFromRole(user.Id, role.Name);
                }
            }
        }

        //
        // GET: User/Delete
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                // Get user from database
                var user = database.Users.Where(u => u.Id == id).First();

                // Check if user exists
                if (user == null)
                {
                    return HttpNotFound();
                }

                return View(user);
            }
        }

        //
        // Post: User/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                // Get user from database
                var user = database.Users.Where(u => u.Id == id).First();

                // Get user articles from database
                var userArticles = database.Articles.Where(a => a.AuthorId == user.Id);

                // Delete user articles
                foreach (var article in userArticles)
                {
                    database.Articles.Remove(article);
                }

                // Get user Comments from database
                var comments = database.Comments.Where(c => c.AuthorId.Equals(user.Id));

                // Delete user Comments
                foreach (var comment in comments)
                {
                    database.Comments.Remove(comment);
                }

                // Delete user and save changes
                database.Users.Remove(user);
                database.SaveChanges();

                return RedirectToAction("List");
            }
        }
    }
}