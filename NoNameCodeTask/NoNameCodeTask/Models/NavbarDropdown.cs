using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoNameCodeTask.Models
{
	public class NavbarDropdown
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Path { get; set; }

		public Navbar Navbar { get; set; }
		public int Navbar_Id { get; set; }
	}
}