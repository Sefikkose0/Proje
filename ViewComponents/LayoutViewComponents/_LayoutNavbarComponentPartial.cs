using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
