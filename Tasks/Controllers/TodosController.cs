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
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]

		public IActionResult CreateTodo(TodosModel todo)
		{
			if (ModelState.IsValid)
			{
				_db.Todos.Add(todo);
				_db.SaveChanges();

                return RedirectToAction(nameof(Index));
			}

			return RedirectToAction(nameof(Create));
        }

//GET 
	
        public IActionResult Edit(string? id)
        {
            if (id == null)
                return NotFound();

            var todoItem = _db.Todos.Find(id);

            if (todoItem == null)
                return NotFound();

            return View(todoItem);
        }

//POST

		[HttpPatch]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(TodosModel todo)
		{
            if (ModelState.IsValid)
            {
                _db.Todos.Add(todo);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Create));
        }
       
    }
}

