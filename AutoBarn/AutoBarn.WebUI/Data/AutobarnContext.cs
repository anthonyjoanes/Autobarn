using System.Data.Entity;
using AutoBarn.WebUI.Data.Entities;
using AutoBarn.WebUI.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutoBarn.WebUI.Data
{
    public class AutobarnContext : IdentityDbContext<ApplicationUser>
    {
        public AutobarnContext() : base("AutobarnContext") { }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }

        public static AutobarnContext Create()
        {
            return new AutobarnContext();
        }
    }
}
