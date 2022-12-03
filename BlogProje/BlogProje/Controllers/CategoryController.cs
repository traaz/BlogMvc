using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager manager = new CategoryManager();
        public ActionResult Index()
        {
            var categoryValues = manager.GetAll();
            return View(categoryValues);
        }
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = manager.GetAll();

            return PartialView(categoryValues);
        }
    

    }
}