using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Selectors.Controllers
{
    public class SelectorController : Controller
    {
        // GET: Selector
        public ActionResult Index()
        {
            return View();
        }

        //Sayfa adı Personels olmasına rağmen Calisanlar olarak çağrılmasını sağlar.
        [ActionName("Calisanlar")]
        public ActionResult Personels()
        {
            return Content("Çalışanlar sayfası");
        }

        //NonAction: Sayfa aslında olmasına rağmen hiç yokmuş gibi davranmasını sağlar ve sayfaya ulaşılmak istendiğinde 404 hatası verir.
        [NonAction]
        [ActionName("Kampanyalar")]
        public ActionResult Campaings()
        {
            return Content("Kampanyalar sayfası");
        }

        [HttpGet]
        public ActionResult Detail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            return Content("Kayıt başarıyla eklendi.");
        }

        [HttpPut]
        public ActionResult Update()
        {
            return Content("Kayıt başarıyla güncellendi.");
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Content("Kayıt başarıyla silindi.");
        }
    }
}