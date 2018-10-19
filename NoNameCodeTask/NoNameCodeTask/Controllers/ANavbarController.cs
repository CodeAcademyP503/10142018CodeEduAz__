using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationtest.Controllers
{
    public class ANavbarController : Controller
    {
        // GET: ANavbar
        public ActionResult Index()
        {
            return View();
        }


		public ActionResult Create()
		{
			return View();
		}
    }
}