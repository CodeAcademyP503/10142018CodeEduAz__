using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using NoNameCodeTask.Models;

namespace NoNameCodeTask.Controllers
{
    public class NavbarController : Controller
    {
		private readonly CodeTaskDbContext _testDbContext;

		public NavbarController()
		{
			_testDbContext = new CodeTaskDbContext();
		}
		// GET: Navbar
		//[HttpGet]
		public ActionResult GetData()
		{
			//ViewBag.Menu = _testDbContext.Navbars.ToList();
			List<Menu> Menus = _testDbContext.Menus.ToList();
			return PartialView("GetData",Menus);
		}

		protected override void Dispose(bool disposing)
		{
			if(disposing)
			_testDbContext.Dispose();
		}
	}
}