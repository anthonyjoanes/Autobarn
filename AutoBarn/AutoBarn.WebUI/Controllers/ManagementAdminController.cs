using System.Web.Mvc;

namespace AutoBarn.WebUI.Controllers
{
    [Authorize]
    public class ManagementAdminController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}