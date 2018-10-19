using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using NoNameCodeTask.Models;

namespace WebApplicationtest.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeTaskDbContext codeDb;

        public HomeController()
        {
            codeDb = new CodeTaskDbContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Wrapper()
        {
            List<HomeImageSlider> homeImageSliders = codeDb.HomeImageSliders.ToList();

            return View();
        }
        public ActionResult HomeSlider()
        {
            List<HomeImageSlider> homeImageSliders = codeDb.HomeImageSliders.ToList();

            return PartialView(homeImageSliders);
        }
        public ActionResult EventList()
        {
            List<NewsContent> newsContents = codeDb.NewsContents.ToList();

            return PartialView(newsContents);
        }
        //public ActionResult Part()
        //{
        //	List<Navbar> model = new List<Navbar>()
        //	{
        //		new Navbar
        //		{
        //			Name="Index",
        //			Path="dsadsa"
        //		},
        //		new Navbar
        //		{
        //			Name="Mezunlar",
        //			Path="/Navbar/Mezunlar"
        //		},
        //		new Navbar
        //		{
        //			Name="Shamil",
        //			Path="dsadad"
        //		}
        //	};
        //	return PartialView("Test",model);
        //}
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                codeDb.Dispose();
        }
    }
}