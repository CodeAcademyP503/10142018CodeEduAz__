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

        //=======================Wrapper Start============================================= 
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
        //=======================Wrapper End============================================= 

        public ActionResult AcademySubjects()
        {
            List<SubjectPrograms> subjectPrograms = codeDb.SubjectPrograms.ToList();

            return View(subjectPrograms);
        }
        //=======================commentSlide Start============================================= 
        public ActionResult CommentSliders()
        {
            List<CommentSlider> commentSliders = codeDb.CommentSliders.ToList();

            return PartialView(commentSliders); 
        }
        //=======================CommentSlide End============================================= 

        //=======================partnerSlide Start============================================= 
        public ActionResult PartnersAcademy()
        {
            List<PartnersAcademy> partnersAcademies = codeDb.PartnersAcademies.ToList();

            return PartialView(partnersAcademies);
        }

        //=======================partnerSlide End============================================= 

        public ActionResult Footer()
        {
            List<MenuItem> menuItems = codeDb.Dropdowns.ToList().OrderByDescending(x=>x.Id).ToList();
            List<Menu> menus = codeDb.Menus.ToList();

            return PartialView(menus);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                codeDb.Dispose();
        }
    }
}