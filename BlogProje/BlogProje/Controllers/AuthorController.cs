using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class AuthorController : Controller
    {

        BlogManager bm = new BlogManager();
        AuthorManageer aManager= new AuthorManageer();
        // GET: Author
        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetails = bm.GetBlogById(id);

            return PartialView(authorDetails);
        }
        public PartialViewResult PopularPost(int id)
        {
            var blogAouthorId= bm.GetAll().Where(x=>x.BlogId==id).Select(y=>y.AuthorId).FirstOrDefault();
            ViewBag.AuthorId = blogAouthorId;
            var authorBlogs = bm.GetBlogByAuthor(blogAouthorId);
            return PartialView(authorBlogs);
        }
        public ActionResult AuthorList()
        {
            var authorList=aManager.GetAll();
            return View(authorList);
        }
        [HttpGet]
        public ActionResult AddAuthor() 
            {
            return View();
            } 
         [HttpPost]
        public ActionResult AddAuthor(Author author) 
            {
            aManager.AddAuthor(author);
            return RedirectToAction("AuthorList");
            }
        [HttpGet]
        public ActionResult updateAuthor(int id)
        {
            Author author = aManager.findAuthor(id);
            return View(author);

        }
        [HttpPost]
        public ActionResult updateAuthor(Author author)
        {
            aManager.updateAuthor(author);
            return RedirectToAction("AuthorList");

        }

    }
}