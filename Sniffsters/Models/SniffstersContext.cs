using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Sniffsters.Models
{

    public class SniffstersContext : IdentityDbContext<ApplicationUser>
    {
        public SniffstersContext()
            : base("SniffstersEntities")
        {
        }

    
    }
}