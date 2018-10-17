using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoNameCodeTask.Models
{
	public class Login
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
	}
}