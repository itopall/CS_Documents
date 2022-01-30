using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Controllers
{
    public class OtherController : BaseController
    {
        // GET: Other
        public ActionResult Error()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult UnAuthorized()
        {
            return View();
        }
    }
}