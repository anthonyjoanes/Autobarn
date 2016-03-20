using System.Web.Mvc;

namespace AutoBarn.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin/Main
        public ActionResult Index()
        {
            return View();
        }
    }
}