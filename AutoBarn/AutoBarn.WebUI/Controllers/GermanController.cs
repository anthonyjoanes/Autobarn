using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Infrastructure.Filters;

namespace AutoBarn.WebUI.Controllers
{
    public class GermanController : Controller
    {
        // GET: German
        public ActionResult Brands(string heading = "")
        {
            var dictionary = new Dictionary<string, string>
            {
                {"VW_Audi_Seat_And_Skoda_Servicing", "VW, Audi, Seat & Skoda Servicing"},
                {"BMW_Servicing_specialists", "BMW Servicing specialists"},
                {"Mercedes_Servicing_specialists", "Mercedes Servicing specialists"},
                {"Motorhome_Servicing_And_Class_7_MOTs", "Motorhome Servicing & Class 7 MOT's"}
            };




            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            ViewBag.BrandHeading = dictionary.ContainsKey(heading) ? dictionary[heading] : string.Empty;
            return View();
        }

        [ActionName("VW_Audi_Seat_And_Skoda_Servicing")]
        public ActionResult VwAudiSeatSkoda()
        {
            return View();
        }

        [ActionName("BMW_Servicing_specialists")]
        public ActionResult Bmw()
        {
            return View();
        }

        [ActionName("Mercedes_Servicing_specialists")]
        public ActionResult Mercedes()
        {
            return View();
        }

        [ActionName("Motorhome_Servicing_And_Class_7_MOTs")]
        public ActionResult MotorHome()
        {
            return View();
        }
    }
}