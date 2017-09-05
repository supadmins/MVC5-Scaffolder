﻿using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new StyleBundle("~/content/smartadmin").IncludeDirectory("~/Content/css", "*.min.css"));

            bundles.Add(new StyleBundle("~/content/smartadmin").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/demo.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/invoice.min.css",
                "~/Content/css/lockscreen.min.css",
                "~/Content/css/smartadmin-production-plugins.min.css",
                "~/Content/css/smartadmin-production.min.css",
                "~/Content/css/smartadmin-rtl.min.css",
                "~/Content/css/smartadmin-skins.min.css",
                "~/Content/css/your_style.min.css"));


            bundles.Add(new ScriptBundle("~/scripts/smartadmin").Include(
                "~/scripts/app.config.js",
                "~/scripts/plugin/jquery-touch/jquery.ui.touch-punch.min.js",
                "~/scripts/bootstrap/bootstrap.min.js",
                "~/scripts/notification/SmartNotification.min.js",
                "~/scripts/smartwidgets/jarvis.widget.min.js",
                "~/scripts/plugin/jquery-validate/jquery.validate.min.js",
                "~/scripts/plugin/masked-input/jquery.maskedinput.min.js",
                "~/scripts/plugin/select2/select2.min.js",
                "~/scripts/plugin/bootstrap-slider/bootstrap-slider.min.js",
                "~/scripts/plugin/bootstrap-progressbar/bootstrap-progressbar.min.js",
                "~/scripts/plugin/msie-fix/jquery.mb.browser.min.js",
                "~/scripts/plugin/fastclick/fastclick.min.js",
                "~/scripts/app.min.js"));

            bundles.Add(new ScriptBundle("~/scripts/full-calendar").Include(
                "~/scripts/plugin/moment/moment.min.js",
                "~/scripts/plugin/fullcalendar/jquery.fullcalendar.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/charts").Include(
                "~/scripts/plugin/easy-pie-chart/jquery.easy-pie-chart.min.js",
                "~/scripts/plugin/sparkline/jquery.sparkline.min.js",
                "~/scripts/plugin/morris/morris.min.js",
                "~/scripts/plugin/morris/raphael.min.js",
                "~/scripts/plugin/flot/jquery.flot.cust.min.js",
                "~/scripts/plugin/flot/jquery.flot.resize.min.js",
                "~/scripts/plugin/flot/jquery.flot.time.min.js",
                "~/scripts/plugin/flot/jquery.flot.fillbetween.min.js",
                "~/scripts/plugin/flot/jquery.flot.orderBar.min.js",
                "~/scripts/plugin/flot/jquery.flot.pie.min.js",
                "~/scripts/plugin/flot/jquery.flot.tooltip.min.js",
                "~/scripts/plugin/dygraphs/dygraph-combined.min.js",
                "~/scripts/plugin/chartjs/chart.min.js",
                "~/scripts/plugin/highChartCore/highcharts-custom.min.js",
                "~/scripts/plugin/highchartTable/jquery.highchartTable.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/datatables").Include(
                "~/scripts/plugin/datatables/jquery.dataTables.min.js",
                "~/scripts/plugin/datatables/dataTables.colVis.min.js",
                "~/scripts/plugin/datatables/dataTables.tableTools.min.js",
                "~/scripts/plugin/datatables/dataTables.bootstrap.min.js",
                "~/scripts/plugin/datatable-responsive/datatables.responsive.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/jq-grid").Include(
                "~/scripts/plugin/jqgrid/jquery.jqGrid.min.js",
                "~/scripts/plugin/jqgrid/grid.locale-en.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/forms").Include(
                "~/scripts/plugin/jquery-form/jquery-form.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/smart-chat").Include(
                "~/scripts/smart-chat-ui/smart.chat.ui.min.js",
                "~/scripts/smart-chat-ui/smart.chat.manager.min.js"
                ));

            bundles.Add(new ScriptBundle("~/scripts/vector-map").Include(
                "~/scripts/plugin/vectormap/jquery-jvectormap-1.2.2.min.js",
                "~/scripts/plugin/vectormap/jquery-jvectormap-world-mill-en.js"
                ));

           




            //EasyUI style
            bundles.Add(new StyleBundle("~/plugins/easyuiStyles").Include(
                        "~/fonts/font-awesome3.2/css/font-awesome.css",
                        "~/Scripts/easyui/themes/insdep/easyui.css",
                        "~/Scripts/easyui/themes/insdep/easyui_animation.css",
                      "~/Scripts/easyui/themes/insdep/easyui_plus.css"
                      ));
            //EasyUI Script
            bundles.Add(new ScriptBundle("~/plugins/easyuijs").Include(
                      "~/Scripts/easyui/jquery.easyui.min.js"));
            //EasyUI plugins Script
            bundles.Add(new ScriptBundle("~/plugins/easyuipluginsjs").Include(
                      "~/Scripts/easyui/plugins/datagrid-filter.js",
                      "~/Scripts/easyui/plugins/jquery.edatagrid.js"));


            //moment Script
            bundles.Add(new ScriptBundle("~/plugins/momentjs").Include(
                      "~/Scripts/moment-with-locales.js"));


            //jquery.filer Script
            bundles.Add(new StyleBundle("~/plugins/jqueryfilerStyles").Include(
                      "~/Scripts/plugin/jquery-filer/css/jquery.filer.css",
                      "~/Scripts/plugin/jquery-filer/css/themes/jquery.filer-dragdropbox-theme.css"));
            bundles.Add(new ScriptBundle("~/plugins/jqueryfilerjs").Include(
                      "~/Scripts/plugin/jquery-filer/js/jquery.filer.min.js"));
            //FileSaver Script
            bundles.Add(new ScriptBundle("~/plugins/filejs").Include(
                      "~/Scripts/FileSaver.js",
                      "~/Scripts/jquery.fileDownload.js"
                      ));



            //format enum json
            bundles.Add(new ScriptBundle("~/plugins/enumformatterjs").Include(
                      "~/Scripts/jquery.extend.js",
                      "~/Scripts/enum.json.js",
                       "~/Scripts/datagrid.formatter.js"));





            BundleTable.EnableOptimizations = false;

        }
    }
}
