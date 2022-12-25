using Business.Concrete;
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
    }
}