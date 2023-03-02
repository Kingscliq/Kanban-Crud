using System;
using Microsoft.AspNetCore.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
	public class TodosController : Controller
	{

		private static List<TodosModel> task = new List<TodosModel>();

		public IActionResult Index()
		{
            return View(task);
		}

        public IActionResult Create()
        {
			var todo = new TodosModel();
            return View();
        }

		public IActionResult CreateTodo(TodosModel todoModel)
		{
			task.Add(todoModel);
			return RedirectToAction(nameof(Index));
		}
    }
}

