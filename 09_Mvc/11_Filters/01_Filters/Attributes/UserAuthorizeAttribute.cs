using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Filters.Attributes
{
    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        //Base'den gelen AuthorizeCore methodunu kendi login mantığımıza göre override ettik, eğer AktifKullanici null değil ise login işlemi gerçekleştirilmiş demektir ve gidilmek istenen sayfaya izin verilir. Aksi halde anasayfaya yönlendirilir.
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (HttpContext.Current.Session["AktifKullanici"] == null)
            {
                httpContext.Response.Redirect("~/Home/Login");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}