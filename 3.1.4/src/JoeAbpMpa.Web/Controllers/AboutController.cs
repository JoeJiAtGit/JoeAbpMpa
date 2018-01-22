using System.Web.Mvc;

namespace JoeAbpMpa.Web.Controllers
{
    public class AboutController : JoeAbpMpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}