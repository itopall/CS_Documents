using _01_CRUDOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_CRUDOperations.Controllers
{
    public class OgrenciController : Controller
    {
        static List<OgrenciModel> OgrenciList = new List<OgrenciModel>
        {
            new OgrenciModel { Id = 1, AdSoyad = "Bahadır", Bolum = "Veritabanı" },
            new OgrenciModel { Id = 2, AdSoyad = "Ömer", Bolum = "Yazılım" },
            new OgrenciModel { Id = 3, AdSoyad = "Rümeysa", Bolum = "Tasarım" }
        };

        // GET: Ogrenci
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OgrenciListe()
        {
            var model = new OgrenciListModel();
            model.OgrenciListesi = OgrenciList;

            return View(model);
        }

        public ActionResult OgrenciDetay(int? id)
        {
            var model = new OgrenciModel();
            model = OgrenciList.FirstOrDefault(p => p.Id == id);

            return View(model);
        }

        //Öğrenci ekleme sayfasının view'ını yani sayfanın kendisini döner
        public ActionResult OgrenciEkle()
        {
            var model = new OgrenciModel();
            model.Bolum = "Yazılım";

            return View(model);
        }

        //Eklenecek öğrencinin bilgilerini parametre olarak alır ve ekleme işlemini gerçekleştirir.
        [HttpPost]
        public ActionResult OgrenciEkle(OgrenciModel model)
        {
            //Validasyon vs.

            OgrenciList.Add(model);

            return View("Success");
        }

        public ActionResult OgrenciGuncelle(int? id)
        {
            var model = new OgrenciModel();
            model = OgrenciList.FirstOrDefault(p => p.Id == id);

            return View(model);
        }

        [HttpPost]
        public ActionResult OgrenciGuncelle(OgrenciModel model)
        {
            //Validasyon vs.

            OgrenciList.RemoveAll(p=>p.Id == model.Id);

            OgrenciList.Add(model);

            OgrenciList = OgrenciList.OrderBy(p => p.Id).ToList();

            return View("Success");
        }

        public ActionResult OgrenciSil(int? id)
        {
            var model = new OgrenciModel();
            OgrenciList.RemoveAll(p => p.Id == id);

            return View("Success");
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}