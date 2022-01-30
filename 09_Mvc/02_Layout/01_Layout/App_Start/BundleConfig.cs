using System.Web;
using System.Web.Optimization;

namespace _01_Layout
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
                      //"~/Scripts/menu.js")); buraya kendi menu.js dosyamızı ekleyebiliriz.

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
                      //"~/Content/menu.css")); //buraya kendi menu.css eklenebilir.



            //Kendine özel bir başlık açarak ("~/Content/menu") aşağıdaki şekilde eklenebilir.
            bundles.Add(new StyleBundle("~/Content/menu").Include(
                     "~/Content/menu.css"));

            //Eski siteden gelen menu script'lerini bundle'a ekledik.
            bundles.Add(new ScriptBundle("~/bundles/menu").Include(
                      "~/Scripts/menu.js"));

            //Kendi yazdığımız script'leri bundle'a ekledik.
            bundles.Add(new ScriptBundle("~/bundles/MyScripts").Include(
                      "~/Scripts/MyScripts.js"));
        }
    }
}
