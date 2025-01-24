using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;

namespace webprojesi.Controllers
{
	public class MesajController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values = context.Mesajlar.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadTrue(int id)
		{
			var value = context.Mesajlar.Find(id);
			value.Okundumu = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadFalse(int id)
		{
			var value = context.Mesajlar.Find(id);
			value.Okundumu = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");

		}
		public IActionResult DeleteMessage(int id)
		{
			var value = context.Mesajlar.Find(id);
			context.Mesajlar.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MesajDetayı(int id)
		{
			var value = context.Mesajlar.Find(id);
			return View(value);
		}
	}
}
