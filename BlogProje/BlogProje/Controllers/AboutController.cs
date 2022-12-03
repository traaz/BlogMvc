﻿using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager manager = new AboutManager();
        public ActionResult Index()
        {
            var abouts = manager.GetAll();
            return View(abouts);
        }
        public PartialViewResult Footer()
        {
          
            var abouts =manager.GetAll();
            return PartialView(abouts);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManageer authorManageer= new AuthorManageer();
            var authors = authorManageer.GetAll();
            return PartialView(authors);
        }
    }
}