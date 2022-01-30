using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Routing.Controllers
{
    //RoutePrefix kullanarak aşağıdaki bütün Route'ların başına "otel" yazmaya gerek kalmadan kullanabiliriz. 
    //Linklerin başlangıcındaki ortak kısımlar controller'da tek seferde tanımlanabilirler.
    [RoutePrefix("otel")]       //Kok Route'u belirtir.
    //[Route("{action=DefaultActionTest}")]  //default olarak ele alınacak Action'u belirtir.
    public class HotelController : Controller
    {
        // GET: localhost:44398/Hotel/Index
        [Route()]
        public ActionResult Index()
        {
            return View();
        }

        // GET: localhost:44398/Hotel/Detail
        [Route("detay/{name}")]
        public ActionResult Detail(string name)
        {
            return View();
        }

        // GET: localhost:44398/Hotel/Reservation
        [Route("rezervasyon/{category}/{name}")]
        public ActionResult Reservation(string category, string name)
        {
            return View();
        }


        // GET: localhost:44398/RoutePrefixKullanmayanSayfa
        [Route("~test")]
        public ActionResult RoutePrefixKullanmayanSayfa()
        {
            return View();
        }

        //Route Constraint ile aşağıdaki şekilde url içinde gelecek parametreleri kısıtlayabiliriz.
        [Route("kontrolparametre/{id:int:min(1)}")]
        public ActionResult CheckParameter(int id)
        {
            return View();
        }

        [Route("kontrolparametrestring/{name:maxlength(5)?}")]
        public ActionResult CheckParameterString(string name)
        {
            return View();
        }


        //Default olarak açılmasını istediğimiz sayfa
        public ActionResult DefaultActionTest()
        {
            return View();
        }


        //QueryString Kullanımı
        [Route("qsdeneme")]
        public ActionResult QueryStringDeneme()
        {
            var category = Request.QueryString["category"];
            var name = Request.QueryString["name"];

            return View();
        }
    }
}