using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoBarn.WebUI.Controllers
{
    public class PegasusController : Controller
    {
        // GET: Pegasus
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Automatic-Electric-Side-Steps")]
        public ActionResult SideSteps()
        {
            return View();
        }

        [ActionName("Hard-Tops")]
        public ActionResult HardTops()
        {
            return View();
        }

        [ActionName("Top-Up-Covers")]
        public ActionResult TopUpCovers()
        {
            return View();
        }

        [ActionName("Sports-Lids")]
        public ActionResult SportsLids()
        {
            return View();
        }

        public ActionResult Accessories()
        {
            return View();
        }
    }
}