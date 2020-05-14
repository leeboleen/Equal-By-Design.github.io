Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css"))

#Region "EqbD"

        bundles.Add(New ScriptBundle("~/template/js").Include(
                  "~/Scripts/jquery.js",
                  "~/Scripts/bootstrap.min.js",
                  "~/Scripts/jquery.parallax.js",
                  "~/Scripts/owl.carousel.min.js",
                  "~/Scripts/jquery.magnific-popup.min.js",
                  "~/Scripts/magnific-popup-options.js",
                  "~/Scripts/modernizr.custom.js",
                  "~/Scripts/smoothscroll.js",
                  "~/Scripts/custom.js"
                  ))

        bundles.Add(New StyleBundle("~/template/css").Include(
                  "~/Content/css/bootstrap.min.css",
                  "~/Content/css/font-awesome.min.css",
                  "~/Content/css/magnific-popup.css",
                  "~/Content/css/owl.theme.css",
                  "~/Content/css/owl.carousel.css",
                  "~/Content/css/tooplate-style.css"
))

#End Region


    End Sub
End Module

