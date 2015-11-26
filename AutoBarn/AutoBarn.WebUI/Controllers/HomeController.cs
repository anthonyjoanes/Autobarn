using System.Linq;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}