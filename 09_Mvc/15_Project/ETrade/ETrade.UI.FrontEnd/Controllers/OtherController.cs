using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.FrontEnd.Controllers
{
    public class OtherController : BaseController
    {
        // GET: Other
        public ActionResult Error()
        {
            ViewBag.PageTitle = "Error 500";
            return View();
        }

        public ActionResult NotFound()
        {
            ViewBag.PageTitle = "404 Not Found";
            return View();
        }

        public ActionResult UnAuthorized()
        {
            ViewBag.PageTitle = "UnAuthorize";
            return View();
        }
    }
}