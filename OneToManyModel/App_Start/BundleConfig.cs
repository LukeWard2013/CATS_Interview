
using System.Web.Optimization;

namespace CATS_Interview.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", 
                        "~/Scripts/jquery.simple-dtpicker.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/themes/custom/AllCss").Include("~/Content/themes/custom/catsInterview.css",
                                        "~/Content/themes/custom/jquery.simple-dtpicker.css",
                                        "~/Content/themes/custom/jquery-ui-1.10.4.custom.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}