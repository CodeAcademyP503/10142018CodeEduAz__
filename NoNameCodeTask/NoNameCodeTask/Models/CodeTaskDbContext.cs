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
		public DbSet<Login> Logins { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<MenuItem> Dropdowns { get; set; }
		public DbSet<CommentSlider> CommentSliders { get; set; }
		public DbSet<HomeImageSlider> HomeImageSliders { get; set; }
		public DbSet<NewsContent> NewsContents { get; set; }
		public DbSet<PartnersAcademy> PartnersAcademies { get; set; }
		public DbSet<Services> Services { get; set; }
		public DbSet<SubjectPrograms> SubjectPrograms { get; set; }
	}
}