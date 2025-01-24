using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents
{
	public class _ContactComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
