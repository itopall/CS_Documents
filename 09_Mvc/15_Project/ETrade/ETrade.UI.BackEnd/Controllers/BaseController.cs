using ETrade.UI.BackEnd.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrade.UI.BackEnd.Controllers
{
    [LogActionFilter]   
    [Exception]
    public class BaseController : Controller
    {
    }
}