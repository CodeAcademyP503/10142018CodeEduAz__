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
        // GET: Home
        public ActionResult Index()
        {
            return View();
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
	}
}