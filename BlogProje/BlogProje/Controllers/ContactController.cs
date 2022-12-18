using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager manager = new ContactManager();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(Contact c)
        {
            manager.ContactAdd(c);
            return View();
        }
        public ActionResult SendBox()
        {
            var messageList = manager.GetAll();
          
            return View(messageList);
        }
        public ActionResult MessageDetails(int id) {
            Contact contact = manager.GetContactDetails(id);
            return View(contact);
                
        
        }
    }
}