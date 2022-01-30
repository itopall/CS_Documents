using System.Web;
using System.Web.Optimization;

namespace ETrade.UI.BackEnd
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/AdminLteCss").Include(
                      "~/Content/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                      "~/Content/plugins/jqvmap/jqvmap.min.css",
                      "~/Content/dist/css/adminlte.min.css",
                      "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                      "~/Content/plugins/daterangepicker/daterangepicker.css",
                      "~/Content/plugins/summernote/summernote-bs4.css",
                      "~/Content/plugins/summernote/summernote-bs4.min.css",

                      //DataTable
                      "~/Content/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css",
                      "~/Content/plugins/datatables-responsive/css/responsive.bootstrap4.min.css",
                      "~/Content/plugins/datatables-buttons/css/buttons.bootstrap4.min.css"
                      ));

            bundles.Add(new StyleBundle("~/bundles/siteCss").Include(
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/AdminLteScripts").Include(
                        //"~/Content/plugins/jquery/jquery.min.js",
                        //"~/Content/plugins/jquery-ui/jquery-ui.min.js",
                        "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/plugins/chart.js/Chart.min.js",
                        "~/Content/plugins/sparklines/sparkline.js",
                        "~/Content/plugins/jqvmap/jquery.vmap.min.js",
                        "~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js",
                        "~/Content/plugins/jquery-knob/jquery.knob.min.js",
                        "~/Content/plugins/moment/moment.min.js",
                        "~/Content/plugins/daterangepicker/daterangepicker.js",
                        "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                        "~/Content/plugins/summernote/summernote-bs4.min.js",
                        "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                        "~/Content/dist/js/adminlte.js",
                        "~/Content/dist/js/demo.js",
                        "~/Content/dist/js/pages/dashboard.js",

                        //Datatable
                        "~/Content/plugins/datatables/jquery.dataTables.min.js",
                        "~/Content/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
                        "~/Content/plugins/datatables-responsive/js/dataTables.responsive.min.js",
                        "~/Content/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
                        "~/Content/plugins/datatables-buttons/js/dataTables.buttons.min.js",
                        "~/Content/plugins/datatables-buttons/js/buttons.bootstrap4.min.js",
                        "~/Content/plugins/jszip/jszip.min.js",
                        "~/Content/plugins/pdfmake/pdfmake.min.js",
                        "~/Content/plugins/pdfmake/vfs_fonts.js",
                        "~/Content/plugins/datatables-buttons/js/buttons.html5.min.js",
                        "~/Content/plugins/datatables-buttons/js/buttons.print.min.js",
                        "~/Content/plugins/datatables-buttons/js/buttons.colVis.min.js",
                        "~/Content/dist/js/adminlte.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/siteScripts").Include(
                        "~/Content/siteScripts.js"));


        }
    }
}
