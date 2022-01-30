using _01_HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_HtmlHelpers.Controllers
{
    public class HtmlHelpersController : Controller
    {
        // GET: HtmlHelpers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductEdit()
        {
            ProductModel model = new ProductModel
            {
                Id = 1,
                Name = "Thinkpad",
                Description = "Ürün detay bilgileri vs.",
                IsActive = true
            };

            return View(model);
        }

        public ActionResult UpdatePersonel(ProductModel model)
        {
            //Db güncelleme işlemleri

            return View("ProductEdit", model);
        }
        
    }
}