using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_VeriTasimaYontemleri.Controllers
{
    public class VeriTasimaController : Controller
    {
        // GET: VeriTasima
        public ActionResult Index()
        {
            //Sadece aynı Index sayfasının View'ında burada atadığımız bilgi görünebilir.
            ViewBag.Message = "ViewBag nesnesi oluşturulmuştur.";
            ViewData["Message2"] = "ViewData nesnesi oluşturulmuştur.";
            TempData["Message3"] = "TempData nesnesi oluşturulmuştur.";
            Session["KullaniciAdi"] = "Hasan Ali";

            //return RedirectToAction("Detail", "VeriTasima");
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Message = "ViewBag nesnesi oluşturulmuştur. Detail'a özel olarak";
            ViewData["Message2"] = "ViewData nesnesi oluşturulmuştur. Detail'a özel olarak";

            return View();
        }
    }
}