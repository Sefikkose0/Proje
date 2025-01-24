using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents
{
	public class _NavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
