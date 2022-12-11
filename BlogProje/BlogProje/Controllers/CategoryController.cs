using Business.Concrete;
using Entity.Concrete;
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
        public ActionResult AdminCategoryList()
        {
            var categoryValues = manager.GetAll();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            manager.AddCategory(category);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult deleteCategory(int id)
        {
            manager.deleteCategory(id);
            return RedirectToAction("AdminCategoryList");
        }

    }
}