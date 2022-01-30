using _01_Filters.Attributes;
using _01_Filters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Controllers
{
    //[LogActionFilter] //BaseController'da bu filter'ları yazdığımız için burada tekrar uygulamamıza gerek kalmadı.
    //[Exception]
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            PersonelModel model = new PersonelModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(PersonelModel model)
        {
            //Validasyon
            //Db üzerinden username password kontrol edilir.

            var result = true;
            if (result)
            {
                //Bu bilgiler db'den select edilerek elde edilecek normalde ancak db bağlantımız olmadığı için şuan manuel olarak doldurduk.
                model.IsAdmin = true;
                model.NameSurname = model.Username;
                model.Id = 1000;

                Session["AktifKullanici"] = model; //Login olan kullanıcıya ait bilgileri daha sonra kullanmak için Session'da saklıyoruz.
                Session.Timeout = 10; //timeout süresini bu şekilde belirleyebiliriz. (dk. olarak)

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon(); //Session'ı düşürerek kullanıcının çıkış yapmasını sağlar.

            return RedirectToAction("Index");
        }
    }
}