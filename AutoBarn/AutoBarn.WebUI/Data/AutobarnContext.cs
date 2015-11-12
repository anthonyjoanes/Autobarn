using System.Data.Entity;
using AutoBarn.WebUI.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutoBarn.WebUI.Data
{
    public class AutobarnContext : IdentityDbContext<ApplicationUser>
    {
        public AutobarnContext() : base("AutobarnContext") { }
        public virtual DbSet<Contact> Contacts { get; set; }

        public static AutobarnContext Create()
        {
            return new AutobarnContext();
        }
    }
}
