using _01_Filters.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Controllers
{
    //Filter'lar controller seviyesinde uygulanabilir. Böyle yapılırsa controller içindeki bütün methodlara uygulanmış olur.
    //[UserAuthorize] - //Login kontrolü için attribute'ü
    [UserAuthorize]
    //[LogActionFilter] - //BaseController'da bu filter'ları yazdığımız için burada tekrar uygulamamıza gerek kalmadı.
    //[Exception]
    public class PersonelController : BaseController
    {
        // GET: Personel
        //[Exception] //ExceptionFilter istenirse bazı ActionMethodlara uygulanabilir.
        //İstersek sadece bazı action methodlara filter uygulayıp bazılarına uygulamayabiliriz. Böylelikle bazı sayfalara login olma zorunluluğu getirilirken bazılarına uygulanmayabilir.
        //[UserAuthorize]
        public ActionResult Index()
        {
            //if (Session["AktifKullanici"] == null)
            //{
            //    return RedirectToAction("Login", "Home");
            //}

            //ExceptionFilter olmasaydı her action method'un içerisinde aşağıdaki şekilde try-catch'ler yazmamız gerekirdi.
            //try
            //{
            //    throw new Exception("Manuel olarak hata fırlatıldı");
            //}
            //catch (Exception ex)
            //{
            //    Session["ErrorMessage"] = ex;
            //}

            //Manuel olarak hata fırlatıp ExceptionFilter'ı tetikliyoruz.
            throw new Exception("Manuel olarak hata fırlatıldı");

            return View();
        }

        //[Exception]
        //[UserAuthorize]
        [AdminAuthorize]
        public ActionResult Detail()
        {
            //if (Session["AktifKullanici"] == null)
            //{
            //    return RedirectToAction("Login", "Home");
            //}

            //try
            //{
            //    throw new Exception("Manuel olarak hata fırlatıldı");
            //}
            //catch (Exception ex)
            //{
            //    Session["ErrorMessage"] = ex;
            //}

            return View();
        }
    }
}