using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sniffsters.Models;

namespace Sniffsters.Controllers
{
    public class BreederProfileController : Controller
    {
        //
        // GET: /BreederProfile/
        [HttpGet]
        public ActionResult BreederProfileAction()
        {
            ApplicationUser user;
            using (var db = new SniffstersContext())
            {
                user = db.Users.Find(User.Identity.GetUserId());
                var i = user.Id;

            }

            return View(user);
        }

        [HttpPost]
        public ActionResult BreederProfileAction(ApplicationUser user)
        {

            using (var db = new SniffstersContext())
            {
                var userInDb = db.Users.Find(User.Identity.GetUserId());
                userInDb.FirstName = user.FirstName;
                userInDb.LastName = user.FirstName;


            }

            return RedirectToAction("BreederProfileAction");


        }
    }
}