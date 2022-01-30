using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_ResultTypes.Controllers
{
    public class ResultTypeController : Controller
    {
        // GET: ResultType
        public ActionResult Index()
        {
            return View();
        }

        //return olarak Content dönmemize rağmen methodun return tipini ActionResult olarak tanımlayabildik. Bunu yapabilmemizin nedeni ContentResult tipinin ActionResult'dan kalıtım almış olmasıdır.
        public ActionResult Success()
        {
            return Content("İşlem başarıyla tamamlandı...");
        }

        //İstersek ContentResult olarak da tanımlayabiliriz.
        public ContentResult SuccessNew()
        {
            return Content("İşlem başarıyla tamamlandı - 2...");
        }

        public ActionResult Error()
        {
            return Content("Bir hata oluştu! Lütfen daha sonra tekrar deneyiniz!");
        }

        //Geri dönüş tipi ContentResult iken return View olarak bir kullanım gerçekleştiremeyiz. Methodun ResultType'ı ile return ettiği tip aynı olmak zorundadır.
        //public ContentResult SuccessNew2()
        //{
        //    return View();
        //}

        public ActionResult RedirectToActionSample()
        {
            //Bir takım gerçekleştirildi...

            //Yönlendirme yapılıyor.
            var check = true;
            if (check)
            {
                return RedirectToAction("Success", "ResultType");
            }
            else
            {
                return RedirectToAction("Error", "ResultType");
            }
        }

        public ActionResult RedirectToRouteSample()
        {
            //Yönlendirme yapılıyor.
            return RedirectToRoute(new
            {
                controller = "ResultType",
                action = "SuccessNew"
            });
        }

        public ActionResult RedirectSample()
        {
            //Yönlendirme yapılıyor.
            return Redirect("/ResultType/Success");
        }

        public ActionResult FileSample()
        {
            //Browser'ın önizleme özelliği varsa kendi içerisinde açar.
            //return File("/Content/manzara.jpg", "jpg");

            //Önizleme özelliği olsa bile download etmesini istiyorsak, aşağıdaki şekilde kullanabiliriz.
            return File("/Content/manzara.jpg", "jpg", "ManzaraResmidownload.jpg");
        }

        public ActionResult JsonSample()
        {
            //Bu şekilde kullanırsak hata alacaktır! 
            //Hata Detayı: This request has been blocked because sensitive information could be disclosed to third party web sites when this is used in a GET request. To allow GET requests, set JsonRequestBehavior to AllowGet.
            //return Json("Merhaba Json");

            //return Json("Merhaba Json", JsonRequestBehavior.AllowGet);

            return Json("Merhaba Json", "text/html", JsonRequestBehavior.AllowGet);
        }
    }
}