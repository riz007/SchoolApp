using System.Web;
using System.Web.Optimization;

namespace StudentManagementApp
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

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryeasing").Include(
                       "~/Content/vendor/jquery-easing/jquery.easing.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Bootstrap core JavaScript
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"));

            //Custom scripts for all pages
            bundles.Add(new ScriptBundle("~/bundles/admin").Include(
                "~/Scripts/sb-admin.js"));

            //Page level plugin javascript
            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                "~/Content/vendor/chart.js/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                "~/Content/vendor/datatables/jquery.dataTables.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables-demo").Include(
                "~/Content/vendor/datatables/datatables-demo.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables-bootstrap4").Include(
                "~/Content/vendor/datatables/dataTables.bootstrap4.js"));

            bundles.Add(new ScriptBundle("~/bundles/momentjs").Include(
                "~/Scripts/moment.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/datatables/dataTables.bootstrap4.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/vendor/jquery/jquery-ui.min.css",
                      "~/Content/vendor/jquery/jquery-ui.theme.min.css",
                      "~/Content/style/sb-admin.css"));
        }
    }
}
