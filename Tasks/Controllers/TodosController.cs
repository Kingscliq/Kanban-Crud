using System;
using Microsoft.AspNetCore.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
	public class TodosController : Controller
	{
		TodosModel task = new TodosModel("Bingo", "This is a Dog");

		public IActionResult Index()
		{
			return View(task);
		}

        public IActionResult Create()
        {
            return View();
        }
    }
}

