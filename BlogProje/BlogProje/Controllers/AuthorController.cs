using Business.Concrete;
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
    }
}