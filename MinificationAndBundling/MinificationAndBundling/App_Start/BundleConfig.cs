using System.Web.Optimization;

namespace MinificationAndBundling
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            //Creating style bundle
            StyleBundle styleBundle = new StyleBundle("~/Content/NITStyleBundle");
            //adding style files
            styleBundle.Include("~/Content/Header.min.css", "~/Content/Paragraph.min.css");

            //Adding the styleBundles to BundleCollection
            bundles.Add(styleBundle);

            //Creating script bundle
            ScriptBundle scriptBundle = new ScriptBundle("~/Content/NITScriptBundle");

            //adding script files
            styleBundle.Include("~/Content/One.min.js", "~/Content/Two.min.js", "~/Content/Three.min.js");
            //Adding the scriptBundles to BundleCollection
            bundles.Add(scriptBundle);

            // Bundling will also work in debug mode if we add below code
            BundleTable.EnableOptimizations = true;
        }
    }
}