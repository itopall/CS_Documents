using ETrade.Service.Enum;
using ETrade.UI.BackEnd.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Attribute
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
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
                if (SessionHelper.ActiveUser.EmployeeTypeId == (int)EmployeeTypeEnum.Admin)
                {
                    return true;
                }
                else
                {
                    if (!httpContext.Request.IsAjaxRequest())
                    {
                        httpContext.Response.Redirect("~/Other/UnAuthorized");
                    }
                    
                    return false;
                }
            }
        }
    }
}