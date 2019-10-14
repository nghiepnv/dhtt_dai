using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace CustomMVCIdentity
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //My css
            bundles.Add(new StyleBundle("~/Content/alt").Include(
                        "~/Content/Alt/uikit/css/uikit.almost-flat.min.css",
                        "~/Content/icons/flags/flags.min.css",
                        "~/Content/icons/material-design-icons/material-icons.css",
                        "~/Content/Alt/style_switcher.min.css",
                        "~/Content/Alt/main.min.css",
                        "~/Content/Alt/themes_combined.min.css"));
            //Login css
            bundles.Add(new StyleBundle("~/Content/altLogin").Include(
                        "~/Content/Alt/uikit/css/uikit.almost-flat.min.css",
                        "~/Content/icons/flags/flags.min.css",
                        "~/Content/icons/material-design-icons/material-icons.css",
                        "~/Content/Alt/login_page.min.css"));

            //My Js
            bundles.Add(new ScriptBundle("~/bundles/alt").Include(
            "~/Scripts/Alt/common.min.js",
            "~/Scripts/Alt/uikit_custom.min.js",
            "~/Scripts/Alt/altair_admin_common.min.js"));
            //Login Js
            bundles.Add(new ScriptBundle("~/bundles/altLogin").Include(
                        "~/Scripts/Alt/common.min.js",
                        "~/Scripts/Alt/uikit_custom.min.js",
                        "~/Scripts/Alt/altair_admin_common.min.js",
                         "~/Scripts/Alt/login.min.js"
                        ));
        }
    }
}