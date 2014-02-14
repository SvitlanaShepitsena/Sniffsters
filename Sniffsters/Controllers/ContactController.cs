using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sniffsters.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/



        public ActionResult ContactAction()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
	}
}