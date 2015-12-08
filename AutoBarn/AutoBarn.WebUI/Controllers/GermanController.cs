using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoBarn.WebUI.Controllers
{
    public class GermanController : Controller
    {
        // GET: German
        public ActionResult Brands()
        {
            return View();
        }
    }
}