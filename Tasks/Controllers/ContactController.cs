using System;
using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

