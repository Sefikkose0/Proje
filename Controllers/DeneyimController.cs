using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;
using webprojesi.DAL.Entities;

namespace webprojesi.Controllers
{
	public class DeneyimController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult DeneyimList()
		{
			var values = context.Deneyimler.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateExperience(Deneyim deneyim)
		{
			context.Deneyimler.Add(deneyim);
			context.SaveChanges();
			return RedirectToAction("DeneyimList");
		}

		public IActionResult DeleteExperience(int id)
		{
			var value = context.Deneyimler.Find(id);
			context.Deneyimler.Remove(value);
			context.SaveChanges();
			return RedirectToAction("DeneyimList");

		}
		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = context.Deneyimler.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Deneyim deneyim)
		{
			context.Deneyimler.Update(deneyim);
			context.SaveChanges();
			return RedirectToAction("DeneyimList");

		}




	}
}
