﻿using System.Web;
using System.Web.Optimization;

namespace chevron
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/main").Include(
                    "~/DataTables/datatables.min.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/dataTables.editor.min.js",
                    "~/Scripts/moment.min.js",
                    "~/Scripts/bootstrap-datetimepicker.min.js"
                    //"~/DataTables/pdfmake-0.1.18/build/pdfmake.min.js",
                    //"~/DataTables/JSZip-2.5.0/jszip.min.js",
                    //"~/DataTables/pdfmake-0.1.18/build/vfs_fonts.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/DataTables/datatables.min.css",
                    "~/content/editor.dataTables.min.css",
                    "~/Content/bootstrap-datetimepicker.min.css",
                    "~/content/metro-bootstrap.min.css",
                    "~/content/_main.css"
                ));

            bundles.Add(new ScriptBundle("~/Script/xdkJKAds").Include(
                    "~/Scripts/_main.js"
                ));

            bundles.Add(new ScriptBundle("~/Script/cfgxYSa").Include("~/Scripts/_config.js"));


            BundleTable.EnableOptimizations = true;
        }
    }
}