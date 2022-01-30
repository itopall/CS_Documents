using _01_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Validation.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OgrenciEkle()
        {
            var model = new OgrenciModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult OgrenciEkle(OgrenciModel model)
        {
            if (ModelState.IsValid)
            {
                //Hata Yok, Db kayıt işlemleri vs. gerçekleştirilir.

                return View("Index");
            }
            else
            {
                //Hata varsa sayfayı tekrar yükle, hata mesajları ValidationFor ile ekranda gösterilsin.

                return View();
            }
           
        }
    }
}