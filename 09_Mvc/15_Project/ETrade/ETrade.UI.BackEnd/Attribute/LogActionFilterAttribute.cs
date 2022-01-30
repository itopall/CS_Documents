using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ETrade.UI.BackEnd.Attribute
{
    public class LogActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            AuditLog(nameof(OnActionExecuting), filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            AuditLog(nameof(OnActionExecuted), filterContext.RouteData);
        }

        private void AuditLog(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = $"{methodName} - controller: {controllerName} - action: {actionName}";

            //Db'ye ya da dosyaya audit log olarak yazılabilir.
            Debug.WriteLine(message);
        }
    }
}