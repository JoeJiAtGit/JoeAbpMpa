using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace JoeAbpMpa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JoeAbpMpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}