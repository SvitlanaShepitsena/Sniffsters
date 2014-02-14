using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sniffsters.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/
        public ActionResult AboutAction()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
	}
}