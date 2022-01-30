using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Attribute
{
    public class ExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //Burada hata mesajlarını loglayabiliriz!

            if (filterContext.HttpContext.Request.IsAjaxRequest() && filterContext.Exception != null)
            {
                filterContext.HttpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
                filterContext.Result = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new
                    {
                        IsSuccess = false,
                        Message = filterContext.Exception.Message,
                        StackTrace = filterContext.Exception.StackTrace
                    }
                };

                filterContext.ExceptionHandled = true;

                filterContext.HttpContext.Session["ErrorMessage"] = filterContext.Exception;
            }
            else
            {
                base.OnException(filterContext);

                filterContext.HttpContext.Session["ErrorMessage"] = filterContext.Exception;
                filterContext.HttpContext.Response.Redirect("~/Other/Error");
            }
        }
    }
}