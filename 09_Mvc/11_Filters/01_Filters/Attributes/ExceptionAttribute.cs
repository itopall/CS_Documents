using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Attributes
{
    public class ExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //Burada hata mesajlarını loglayabiliriz!

            base.OnException(filterContext);

            filterContext.HttpContext.Session["ErrorMessage"] = filterContext.Exception;
            filterContext.HttpContext.Response.Redirect("~/Other/Error");
        }
    }
}