using System.Web.Mvc;

namespace Sniffsters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomeAction()
        {
            ViewBag.HideSearchBar = true;

            return View();
        }

    }
}