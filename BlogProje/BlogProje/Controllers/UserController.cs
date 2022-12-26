using Business.Concrete;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class UserController : Controller
    {
        // GET: AuthorLogin
        BlogManager bm = new BlogManager();

        UserProfileManager userProfile = new UserProfileManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1(string mail)
        {
            mail = (string)Session["AuthorMail"];
            var profile = userProfile.GetAuthorByMail(mail);
            return PartialView(profile);

        }
        public ActionResult BlogList(string mail)
        {
            mail = (string)Session["AuthorMail"];

            Context c = new Context();
            int id =c.Authors.Where(x=>x.AuthorMail == mail).Select(y=>y.AuthorId).FirstOrDefault();
            var blogs = userProfile.GetBlogByAuthor(id);
            return View(blogs);
        }

        [HttpGet]
        public ActionResult updateBlog(int id)
        {
            Blog blog = bm.findBlog(id);
            DataAccess.Concrete.Context c = new DataAccess.Concrete.Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()

                                           }).ToList();
            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorId.ToString()

                                            }).ToList();

            ViewBag.values = values;
            ViewBag.values2 = values2;
            return View(blog);
        }
        [HttpPost]
        public ActionResult updateBlog(Blog b)
        {
            bm.updateBlog(b);
            DataAccess.Concrete.Context c = new DataAccess.Concrete.Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()

                                           }).ToList();
            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorId.ToString()

                                            }).ToList();

            ViewBag.values = values;
            ViewBag.values2 = values2;

            return RedirectToAction("BlogList");
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            DataAccess.Concrete.Context c = new DataAccess.Concrete.Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()

                                           }).ToList();
            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorId.ToString()

                                            }).ToList();

            ViewBag.values = values;
            ViewBag.values2 = values2;
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog b)
        {
            bm.AddBlog(b);
            return RedirectToAction("BlogList");
        }
        public ActionResult deleteBlog(int id)
        {
            bm.DeleteBlog(id);
            return RedirectToAction("BlogList");
        }
    }
}