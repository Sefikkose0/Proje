﻿using Microsoft.AspNetCore.Mvc;

namespace webprojesi.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
