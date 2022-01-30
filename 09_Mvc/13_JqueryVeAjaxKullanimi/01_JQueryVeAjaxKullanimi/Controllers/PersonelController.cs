using _01_JQueryVeAjaxKullanimi.Helper;
using _01_JQueryVeAjaxKullanimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_JQueryVeAjaxKullanimi.Controllers
{
    public class PersonelController : Controller
    {
        public static List<PersonelModel> _personelList = new List<PersonelModel>
        {
            new PersonelModel { Id = 1, NameSurname = "Rüştü Dinç" },
            new PersonelModel { Id = 2, NameSurname = "Bahadır Soğucaklı" },
            new PersonelModel { Id = 3, NameSurname = "Utku " },
        };

        //PERSONEL EKLEME SAYFALARI
        public ActionResult Index()
        {
            var model = new PersonelModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult PersonelAdd(PersonelModel model)
        {
            try
            {
                _personelList.Add(model);

                //throw new Exception("Manuel hata fırlatıldı!");

                return Json(new { status = true, message = "İşlem başarıyla tamamlandı." });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message });
            }
        }


        //ARAMA SAYFALARI
        public ActionResult PersonelSearch()
        {
            var model = new PersonelSearchModel();
            model.PersonelList = _personelList; // new List<PersonelModel>();

            return View(model);
        }

        [HttpPost]
        public ActionResult PersonelAra(PersonelSearchModel model)
        {
            model.PersonelList = _personelList.Where(p => p.NameSurname.Contains(model.NameSurname)).ToList();

            var list = HtmlHelpers.RenderRazorViewToString(ControllerContext, "~/Views/Personel/_PersonelSearchList.cshtml", model.PersonelList);

            return Json(new { status = true, list = list, message = "İşlem başarıyla tamamlandı...", JsonRequestBehavior.AllowGet });
        }
    }
}