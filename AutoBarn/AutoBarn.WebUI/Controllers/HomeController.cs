using System.Linq;
using System.Runtime.Caching;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;
using AutoBarn.WebUI.Services;
using AutoBarn.WebUI.Services.Filters;
using AutoBarn.WebUI.Models;

namespace AutoBarn.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactEmailService _contactEmailService;

        public HomeController(IContactEmailService contactEmailService)
        {
            _contactEmailService = contactEmailService;
        }

        public ActionResult Index()
        {
            ViewBag.CustomerReviews = "99.9% rated check a trade reviews!";
            ViewBag.Title = "Home";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            ViewBag.Message = "About Auto-Barn Motor Services";

            return View();
        }

        public ActionResult ServiceMot()
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Ramp()
        {
            ViewBag.Message = "Ramp for Hire!";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel contact)
        {

            _contactEmailService.CreateMessage(contact);
            _contactEmailService.SendEmail();

            return View(contact);
        }
    }
}