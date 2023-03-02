using System;
using Microsoft.EntityFrameworkCore;
using Tasks.Models;

namespace Tasks.Data
{
	public class TodosDbContext: DbContext
	{
		public TodosDbContext(DbContextOptions<TodosDbContext> options) : base(options)
		{
		}

		public DbSet<TodosModel> Todos { get; set; }
	}
}

