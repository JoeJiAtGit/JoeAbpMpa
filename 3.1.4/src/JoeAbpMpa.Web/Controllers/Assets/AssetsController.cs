using Abp.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeAbpMpa.Web.Controllers.Assets
{
    public class AssetsController : AbpController
    {
        // GET: Assets
        public ActionResult Index()
        {
            return View();
        }
    }
}