using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ccaliskan_NTier.UI.Areas.Admin.Controllers
{
    //[AllowAuthorizedAttribute(Role.Admin)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}