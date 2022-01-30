using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_AspNetCoreMvc_Giris.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01_AspNetCoreMvc_Giris.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Save(PersonelModel model)
        {
            return View("Index", model);
        }
    }
}