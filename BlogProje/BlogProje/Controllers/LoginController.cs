using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogProje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author author)
        {
            Context c = new Context();
            var userInfo=c.Authors.FirstOrDefault(x=>x.AuthorMail== author.AuthorMail && x.AuthorPassword==author.AuthorPassword);
            if (userInfo!=null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.AuthorMail, false);
                Session["AuthorMail"] = userInfo.AuthorMail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }

           
        }
    }
}