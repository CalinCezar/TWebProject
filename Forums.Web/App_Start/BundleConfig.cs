﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Forums.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            //Bootstrap 
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

            //Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            //Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            //Toaster
            bundles.Add(new StyleBundle("~/bundles/toaster/css").Include("~/Vendors/toastr/toastr.min.css", new CssRewriteUrlTransform()));

            //DataTables
            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include("~/Vendors/datatables/datatables.min.css", new CssRewriteUrlTransform()));

            //assets
                //css
            bundles.Add(new StyleBundle("~/bundles/bootstrap.css").Include("~/assets/css/bootstrap.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/animate/css").Include("~/assets/css/animate.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap.min.css").Include("~/assets/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/editor/css").Include("~/assets/css/editor.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/file/css").Include("~/assets/css/file.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/font-awesome-min/css").Include("~/assets/css/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/loginstyle/css").Include("~/assets/css/loginstyle.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/responsive/css").Include("~/assets/css/responsive.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/assets/css/style.css", new CssRewriteUrlTransform()));
                //js
            bundles.Add(new ScriptBundle("~/bundles/auth/js").Include("~/assets/js/auth.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.js").Include("~/assets/js/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.min.js").Include("~/assets/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/editor/js").Include("~/assets/js/editor.js"));
            bundles.Add(new ScriptBundle("~/bundles/login/js").Include("~/assets/js/login.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-3.1.1/js").Include("~/assets/js/jquery-3.1.1.min.js"));

        }
    }
}