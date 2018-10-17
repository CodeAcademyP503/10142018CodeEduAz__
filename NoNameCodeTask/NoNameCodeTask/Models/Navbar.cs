using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoNameCodeTask.Models
{
	public class Navbar
	{
		public Navbar()
		{
			NavbarDropdowns = new HashSet<NavbarDropdown>();
		}
		public int Id { get; set; }

		public string Name { get; set; }

		public string Path { get; set; }

		public ICollection<NavbarDropdown> NavbarDropdowns { get; set; }
	}
}