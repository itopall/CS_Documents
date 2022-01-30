using _01_Filters.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Controllers
{
    [LogActionFilter]
    [Exception]
    public class BaseController : Controller
    {
        
    }
}