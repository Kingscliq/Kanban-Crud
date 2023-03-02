using System;
using Microsoft.AspNetCore.Mvc;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Controllers
{
	public class TodosController : Controller
	{

		private static List<TodosModel> task = new List<TodosModel>();
		private readonly TodosDbContext _db;

		public TodosController(TodosDbContext db)
		{
			this._db = db;
		}

		public IActionResult Index()
		{
			var todos = _db.Todos.ToList();

			return View(todos);
		}

        public IActionResult Create()
        {
			var todo = new TodosModel();
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CreateTodo(TodosModel todo)
		{
			_db.Todos.Add(todo);
			_db.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
    }
}

