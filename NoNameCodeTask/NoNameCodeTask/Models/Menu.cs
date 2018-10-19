using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoNameCodeTask.Models
{
	public class Menu
	{
		public Menu()
		{
			NavbarDropdowns = new HashSet<MenuItem>();
		}
		public int Id { get; set; }

		public string Name { get; set; }

		public string Path { get; set; }

		public ICollection<MenuItem> NavbarDropdowns { get; set; }
	}
}