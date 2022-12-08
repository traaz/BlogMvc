using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();

        public PartialViewResult CommentList(int id)
        {
            var commentList = cm.CommentByBlog(id);
            return PartialView(commentList);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            cm.CommnetAdd(c);
            return PartialView();
        }
        public ActionResult AdminCommentList()
        {
            var commentList = cm.CommentStatusTrue();
            return View(commentList);
        }
        public ActionResult changeStatusFalse(int id)
        {
            cm.changeCommnetStatusFalse(id);
            return RedirectToAction("AdminCommentList");
        }
    }
}