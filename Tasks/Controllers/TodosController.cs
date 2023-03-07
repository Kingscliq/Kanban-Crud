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

//GET

        //public IActionResult Delete(string? id)
        //{
            
        //        if (id == null)
        //            return NotFound();

        //        var todoItem = _db.Todos.Remove((int)id);

        //        if (todoItem == null)
        //            return NotFound();

        //        return View(todoItem);
            
        //}

        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CreateTodo(TodosModel todo)
		{
          
                _db.Todos.Add(todo);
				_db.SaveChanges();
            TempData["success"] = "Todo Created Successfully";
            return RedirectToAction("Index");
				
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
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(TodosModel todo)
		{
            _db.Todos.Update(todo);
            _db.SaveChanges();
            TempData["success"] = "Todo Updated Successfully";
            return RedirectToAction("Index");

        }

        //GET

        public IActionResult Delete(string? id)
        {
            if (id == null)
                return NotFound();

            var todoItem = _db.Todos.Find(id);

            if (todoItem == null)
                return NotFound();

            return View(todoItem);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTodo(string? id)
        {
            var todo = _db.Todos.Find(id);
            
            if (todo != null)
            {
                _db.Todos.Remove(todo);
                _db.SaveChanges();
                TempData["success"] = "Todo Deleted Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "An Error Occured!";
            }
            return NotFound();

        }

    }
}

