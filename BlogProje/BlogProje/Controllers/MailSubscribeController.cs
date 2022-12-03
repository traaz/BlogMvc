using Business.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class MailSubscribeController : Controller
    {
        // GET: MailSubscribe
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail sM)
        {
            SubscribeMailManager smanager=new SubscribeMailManager();
            smanager.BlAdd(sM);
            return PartialView();
        }
    }
}