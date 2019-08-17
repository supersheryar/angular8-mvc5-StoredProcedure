using System.Web;
using System.Web.Optimization;

namespace angularMvc5
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Script/Bundles").Include(
                       "~/bundles/runtime*",
                       
                       "~/bundles/polyfills*",
                       "~/bundles/vendor*",
                       "~/bundles/main*"));
            bundles.Add(new Bundle("~/Content/Styles").Include("~/bundles/styles*"));


            
        }
    }
}
