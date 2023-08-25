using System;
using Microsoft.EntityFrameworkCore;
using DiscoBookWeb.Models;

namespace DiscoBookWeb.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
		
	}
}

