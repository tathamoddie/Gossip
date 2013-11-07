using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scriptBundle = new Bundle("~/js", new JsMinify());
            scriptBundle.IncludeDirectory("~/Scripts", "*.js");
            bundles.Add(scriptBundle);
        }
    }
}
