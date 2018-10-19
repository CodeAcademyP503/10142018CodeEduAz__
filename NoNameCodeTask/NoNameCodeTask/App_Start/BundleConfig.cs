using System.Web;
using System.Web.Optimization;

namespace NoNameCodeTask
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/Content/fonts").Include(
					  "~/Content/fonts/fonts.css"));

			bundles.Add(new ScriptBundle("~/Content/scripts").Include(
					  "~/Content/scripts/main.js",
					   "~/Content/scripts/vendor.js",
					   "~/Content/scripts/vendor/cleave.min.js",
					   "~/Content/scripts/vendor/js.cookie.min.js",
					   "~/Content/scripts/vendor/modernizr.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/css/main.css",
					  "~/Content/css/vendor.css"));
		}
	}
}
