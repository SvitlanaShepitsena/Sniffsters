using Microsoft.AspNet.Identity.EntityFramework;

namespace Sniffsters.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }


    }
}