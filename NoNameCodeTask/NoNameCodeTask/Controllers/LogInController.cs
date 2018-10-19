using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using NoNameCodeTask.Models;

namespace NoNameCodeTask.Controllers
{
    public class LogInController : Controller
    {
		private readonly CodeTaskDbContext _testDbContext;

		public LogInController()
		{
			_testDbContext = new CodeTaskDbContext();
		}
		// GET: Navbar

        public ActionResult LoginFind()
		{
			return View();
		}

		[HttpPost]
		public ActionResult LoginFind(Login login)
		{
			//ViewBag.Menu = _testDbContext.Navbars.ToList();
			Login logins = _testDbContext.Logins.FirstOrDefault();
			
			if (login.UserName==logins.UserName && login.Password==logins.Password)
			{
				return RedirectToAction("Index","Admin");
			}
			else
			{
				return View();
			}			

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
				_testDbContext.Dispose();
		}
	}
}