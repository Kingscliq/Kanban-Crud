using System;
using Microsoft.EntityFrameworkCore;
using Tasks.Models;

namespace Tasks.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
	}
}

