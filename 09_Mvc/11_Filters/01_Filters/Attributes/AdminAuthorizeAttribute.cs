using _01_Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Attributes
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (HttpContext.Current.Session["AktifKullanici"] == null)
            {
                httpContext.Response.Redirect("~/Home/Login");
                return false;
            }
            else
            {
                var model = (PersonelModel)HttpContext.Current.Session["AktifKullanici"];
                if (model.IsAdmin)
                {
                    return true;
                }
                else
                {
                    httpContext.Response.Redirect("~/Other/UnAuthorized");
                    return false;
                }
            }
        }
    }
}