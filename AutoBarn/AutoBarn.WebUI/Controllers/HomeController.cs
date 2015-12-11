using System.Linq;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;
using AutoBarn.WebUI.Infrastructure;
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
            ViewBag.Message = "About Auto-Barn Motor Services";

            return View();
        }

        public ActionResult ServiceMot()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Meet the team.";
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