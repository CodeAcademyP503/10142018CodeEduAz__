using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NoNameCodeTask.Models
{
	public class CodeTaskDbContext:DbContext
	{
		public CodeTaskDbContext():base("mydb")
		{

		}
	}
}