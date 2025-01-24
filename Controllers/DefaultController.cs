using Microsoft.AspNetCore.Mvc;

namespace webprojesi.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
