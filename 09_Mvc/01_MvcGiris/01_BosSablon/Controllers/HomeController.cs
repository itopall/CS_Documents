using _01_BosSablon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_BosSablon.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonelList()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            var model = new ProductModel();
            model.Id = 1;
            model.Name = "Thinkpad";
            model.Price = 15000;

            return View(model);
        }

        public ActionResult ProductView()
        {
            var model = new ProductModel();
            model.Id = 2;
            model.Name = "Monitor";
            model.Price = 1000;

            return View(model);
        }
    }
}