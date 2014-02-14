using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using Sniffsters.Models;
using System.Collections.Generic;

using System.Web.Mvc;
using System.Web.Security;

namespace Sniffsters.Controllers
{

    public class BreedersController : Controller
    {
        //
        // GET: /DogBreeders/
        public ActionResult BreedersAction()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            using (var db = new SniffstersContext())
            {
                var accUsers = db.Users.Where(e => e.Roles.FirstOrDefault().Role.Name == "Breeders").ToList();

                foreach (var accUser in accUsers)
                {
                    users.Add(new UserViewModel(accUser.UserName));
                }
                return View(users);
            }
        }
    }
}