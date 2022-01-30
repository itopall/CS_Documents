using ETrade.UI.BackEnd.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Attribute
{
    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (SessionHelper.ActiveUser == null)
            {
                if (!httpContext.Request.IsAjaxRequest())
                {
                    httpContext.Response.Redirect("~/Account/Login");
                }
                
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}